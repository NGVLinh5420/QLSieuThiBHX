using QLSieuThiBHX.DAO;
using QLSieuThiBHX.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSieuThiBHX.GUI
{
    public partial class FormHoaDon : Form
    {
        //
        DAO_NhanVien dao_NhanVien = new DAO_NhanVien();
        DAO_KhachHang dao_KhachHang = new DAO_KhachHang();
        DAO_SanPham dao_SanPham = new DAO_SanPham();
        DAO_HD_CTHD dao_HD_CTHD = new DAO_HD_CTHD();

        public FormHoaDon()
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

            //
            string queryKH = "SELECT KH.HoTenKH\r\nFROM KHACHHANG KH";
            DataTable tableKH = DataProvider.Instance.ExecuteQuery(queryKH);

            foreach (DataRow row in tableKH.Rows)
            {
                string hoTenKH = row[0].ToString();
                listHoTenKH.Add(hoTenKH);
            }

            //
            for (int i = 0; i < listHoTenNV.Count; i++)
            {
                cobTenNV.Items.Add(listHoTenNV[i].ToString());
            }

            for (int i = 0; i < listHoTenKH.Count; i++)
            {
                cobTenKH.Items.Add(listHoTenKH[i].ToString());
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

        public void Refresh_HD()
        {
            txtMaHD.Clear();
            cobTenNV.Items.Clear();
            cobTenKH.Items.Clear();
            dtpHoaDon.Text = "01/01/2020";

            LoadListView();
        }

        //LIST VIEW
        private void LoadListView()
        {
            lvHoaDon.Items.Clear();
            lvSanPham.Items.Clear();

            //
            List<DTO_HD_Gia> listHD_Gia = dao_HD_CTHD.ReadDB_Select_HD_Gia();
            foreach (var i in listHD_Gia)
            {
                ListViewItem item = new ListViewItem(i.MaHD.ToString());
                lvHoaDon.Items.Add(item);

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

        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count == 1)
            {
                ListViewItem item = lvHoaDon.SelectedItems[0];
                string maHD = item.SubItems[0].Text;
                txtMaHD.Text = maHD;
                dtpHoaDon.Value = DateTime.Parse(item.SubItems[1].Text);

                // Tên Nhân Viên
                string queryNV = $"SELECT (NV.HoNV + ' ' + NV.TenNV) AS \"HoTenNV\"\r\nFROM NHANVIEN NV, HOADON HD\r\nWHERE HD.MaHD = '{maHD}' AND NV.MaNV = HD.MaNV";
                DataTable tableNV = DataProvider.Instance.ExecuteQuery(queryNV);

                string hoTenNV = "";
                foreach (DataRow row in tableNV.Rows)
                {
                    hoTenNV = row[0].ToString();
                    break;
                }

                cobTenNV.Text = null;
                LoadComboBox();
                cobTenNV.SelectedText = hoTenNV;

                // Tên Khách Hàng
                string queryKH = $"SELECT KH.HoTenKH\r\nFROM KHACHHANG KH, HOADON HD\r\nWHERE HD.MaHD = '{maHD}' AND KH.MaKH = HD.MaKH";
                DataTable tableKH = DataProvider.Instance.ExecuteQuery(queryKH);

                string hoTenKH = "";
                foreach (DataRow row in tableKH.Rows)
                {
                    hoTenKH = row[0].ToString();
                    break;
                }

                cobTenKH.Text = null;
                LoadComboBox();
                cobTenKH.SelectedText = hoTenKH;
            }
            else
            {
                Refresh_HD();
            }
        }

        private void btnLamMoiSP_Click(object sender, EventArgs e)
        {
            LoadListView();
            LoadComboBox();
        }
    }
}
