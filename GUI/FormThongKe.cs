using QLSieuThiBHX.DAO;
using QLSieuThiBHX.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSieuThiBHX.GUI
{
    public partial class FormThongKe : Form
    {
        //Object DAO
        DAO_NhanVien dao_NhanVien = new DAO_NhanVien();
        DAO_KhachHang dao_KhachHang = new DAO_KhachHang();
        DAO_SanPham dao_SanPham = new DAO_SanPham();
        DAO_HD_CTHD dao_HD_CTHD = new DAO_HD_CTHD();

        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            //
            LoadListView();

            //
            LoadComboBox();
        }

        /*
         * Lấy tất cả: Họ Tên Nhân Viên và Khách Hàng
         * Thêm vào ComboBox NhanVien, KhachHang
         */
        private void LoadComboBox()
        {
            //
            cobTenKH.Items.Clear();
            cobTenNV.Items.Clear();

            //
            List<String> listHoTenKH = new List<String>();
            List<String> listHoTenNV = new List<String>();

            //
            string queryNV = "SELECT (NV.HoNV + ' ' + NV.TenNV) AS \"HoTenNV\"\r\nFROM NHANVIEN NV";
            DataTable tableNV = DataProvider.Instance.ExecuteQuery(queryNV);

            foreach (DataRow row in tableNV.Rows)
            {
                string hoTenNV = row[0].ToString();
                listHoTenNV.Add(hoTenNV);
            }

            for (int i = 0; i < listHoTenNV.Count; i++)
            {
                cobTenNV.Items.Add(listHoTenNV[i].ToString());
            }

            //
            string queryKH = "SELECT KH.HoTenKH\r\nFROM KHACHHANG KH";
            DataTable tableKH = DataProvider.Instance.ExecuteQuery(queryKH);

            foreach (DataRow row in tableKH.Rows)
            {
                string hoTenKH = row[0].ToString();
                listHoTenKH.Add(hoTenKH);
            }

            for (int i = 0; i < listHoTenKH.Count; i++)
            {
                cobTenKH.Items.Add(listHoTenKH[i].ToString());
            }
        }

        private void LoadTextBox()
        {
            txtMaKH.Clear();
            txtMaNV.Clear();

            string queryMaKH = $"SELECT MaKH FROM KHACHHANG WHERE HoTenKH = '{cobTenKH.Text}'";
            DataTable tableMaKH = DataProvider.Instance.ExecuteQuery(queryMaKH);

            foreach (DataRow row in tableMaKH.Rows)
            {
                txtMaKH.Text = row[0].ToString();
            }

            string queryMaNV = $"SELECT MaNV FROM NHANVIEN WHERE (HoNV + ' ' +TenNV) = '{cobTenNV.Text}'";
            DataTable tableMaNV = DataProvider.Instance.ExecuteQuery(queryMaNV);

            foreach (DataRow row in tableMaNV.Rows)
            {
                txtMaNV.Text = row[0].ToString();
            }
        }

        // OTHER
        private bool CatchException_NhanVien()
        {
            if (cobTenNV.SelectedItem == null || cobTenKH.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        public void Refresh_TK()
        {
            cobTenNV.Items.Clear();
            cobTenNV.Text = string.Empty;
            cobTenKH.Items.Clear();
            cobTenKH.Text = string.Empty;
            dtpThongKe.Text = "01/01/2020";

            LoadListView();
            LoadComboBox();
        }

        //LIST VIEW
        private void LoadListView()
        {
            lvChiTietHD.Items.Clear();
            lvSanPham.Items.Clear();

            //
            List<DTO_HD_Gia> listHD_Gia = dao_HD_CTHD.ReadDB_Select_HD_Gia();
            foreach (var i in listHD_Gia)
            {
                ListViewItem item = new ListViewItem(i.MaHD.ToString());
                lvChiTietHD.Items.Add(item);

                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, DateTime.Parse(i.NgayLapHD.ToString()).ToShortDateString());
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem(item, i.TongGiaTien.ToString());
                item.SubItems.Add(subItem);
            }

            //
            List<DTO_SP_SoLuong> listSP_SL = dao_HD_CTHD.ReadDB_Select_SP_SoLuong();
            foreach (var i in listSP_SL)
            {
                ListViewItem item = new ListViewItem(i.MaSP.ToString());
                lvSanPham.Items.Add(item);

                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, i.TenSP.ToString());
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem(item, i.TongSoLuong.ToString());
                item.SubItems.Add(subItem);
            }

        }

        private void lvChiTietHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvChiTietHD.SelectedItems.Count == 1)
            {
                ListViewItem item = lvChiTietHD.SelectedItems[0];
                string maHD = item.SubItems[0].Text;
                dtpThongKe.Value = DateTime.Parse(item.SubItems[1].Text);

                //Nhân Viên
                string queryTenNV = $"SELECT (NV.HoNV + ' ' +NV.TenNV) \r\nFROM NHANVIEN NV, HOADON HD\r\nWHERE HD.MaHD = '{maHD}' AND HD.MaNV=NV.MaNV";
                DataTable tableTenNV = DataProvider.Instance.ExecuteQuery(queryTenNV);
                string tenNV = "";
                foreach (DataRow row in tableTenNV.Rows)
                {
                    tenNV = row[0].ToString();
                    break;
                }

                string queryMaNV = $"SELECT NV.MaNV \r\nFROM NHANVIEN NV, HOADON HD\r\nWHERE HD.MaHD = '{maHD}' AND HD.MaNV=NV.MaNV";
                DataTable tableMaNV = DataProvider.Instance.ExecuteQuery(queryMaNV);
                string maNV = "";
                foreach (DataRow row in tableMaNV.Rows)
                {
                    maNV = row[0].ToString();
                    break;
                }

                cobTenNV.Text = null;
                txtMaNV.Text = null;
                LoadComboBox();
                cobTenNV.SelectedText = tenNV;
                txtMaNV.Text = maNV;

                ////
                // Mã Khách Hàng
                //Nhân Viên
                string queryTenKH = $"SELECT KH.HoTenKH \r\nFROM KHACHHANG KH, HOADON HD\r\nWHERE HD.MaHD = '{maHD}' AND HD.MaKH=KH.MaKH";
                DataTable tableTenKH = DataProvider.Instance.ExecuteQuery(queryTenKH);
                string tenKH = "";
                foreach (DataRow row in tableTenKH.Rows)
                {
                    tenKH = row[0].ToString();
                    break;
                }

                string queryMaKH = $"SELECT KH.MaKH \r\nFROM KHACHHANG KH, HOADON HD\r\nWHERE HD.MaHD = '{maHD}' AND HD.MaKH=KH.MaKH";
                DataTable tableMaKH = DataProvider.Instance.ExecuteQuery(queryMaKH);
                string maKH = "";
                foreach (DataRow row in tableMaKH.Rows)
                {
                    maKH = row[0].ToString();
                    break;
                }
                cobTenKH.Text = null;
                txtMaKH.Text = null;
                LoadComboBox();
                cobTenKH.SelectedText = tenKH;
                txtMaKH.Text = maKH;
            }
            else
            {
                Refresh_TK();
            }
        }

        private void btnLamMoiSP_Click(object sender, EventArgs e)
        {
            Refresh_TK();
        }

        private void LoadTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTextBox();
        }
    }
}
