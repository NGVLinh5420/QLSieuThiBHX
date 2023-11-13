using QLSieuThiBHX.DAO;
using QLSieuThiBHX.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSieuThiBHX
{
    public partial class FormNhanVien : Form
    {
        //
        DAO_NhanVien nhanVien = new DAO_NhanVien();

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            //Giới tính mặc định là NAM
            cobGioiTinh.SelectedIndex = 0;

            //Format DateTimePicker
            dtpNhanVien.CustomFormat = "MM/dd/yyyy";

            //
            LoadListView_NhanVien();

        }

        // LISTVIEW
        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count == 1)
            {
                ListViewItem item = lvNhanVien.SelectedItems[0];
                txtMaNV.Text = item.SubItems[0].Text;
                txtHoNV.Text = item.SubItems[1].Text;
                txtTenNV.Text = item.SubItems[2].Text;
                dtpNhanVien.Value = DateTime.Parse(item.SubItems[4].Text);
                txtDiaChiNV.Text = item.SubItems[5].Text;
                txtSDTNV.Text = item.SubItems[6].Text;

                if (item.SubItems[3].Text.ToString().Equals("NAM"))
                {
                    cobGioiTinh.SelectedItem = "NAM";
                }
                else cobGioiTinh.SelectedItem = "NU";

                //if (item.Text.Equals("KH0"))
                //{
                //    MessageBox.Show("Không Thể Sửa hay Xoá Khách Hàng Lạ");
                //}
            }
            else
            {
                Refresh_TextBoxNV();
            }
        }

        private void LoadListView_NhanVien()
        {
            lvNhanVien.Items.Clear();

            //
            List<DTO_NhanVien> listNV = nhanVien.ReadDB_TableNhanVien();
            foreach (var i in listNV)
            {
                ListViewItem item = new ListViewItem(i.MaNV.ToString());
                lvNhanVien.Items.Add(item);

                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, i.HoNV.ToString());
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem(item, i.TenNV.ToString());
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem(item, i.GioiTinhNV.ToString());
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem(item, DateTime.Parse(i.NgSNV.ToString()).ToShortDateString());
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem(item, i.DiaChiNV.ToString());
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem(item, i.SDTNV.ToString());
                item.SubItems.Add(subItem);
            }
        }



        // OTHER
        private bool CatchException_NhanVien()
        {
            if (txtMaNV.TextLength != 0 && txtHoNV.TextLength != 0 && txtTenNV.TextLength != 0 && txtDiaChiNV.TextLength != 0 && txtSDTNV.TextLength != 0)
            {
                return false;
            }
            return true;
        }

        public void Refresh_TextBoxNV()
        {
            txtMaNV.Clear();
            txtHoNV.Clear();
            txtTenNV.Clear();
            cobGioiTinh.SelectedIndex = 0;
            dtpNhanVien.Text = "1/1/2000";
            txtDiaChiNV.Clear();
            txtSDTNV.Clear();

            LoadListView_NhanVien();
        }

        // BUTTON
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (!CatchException_NhanVien())
            {
                //
                List<DTO_NhanVien> listNV = nhanVien.ReadDB_TableNhanVien();
                string maNV = txtMaNV.Text;

                for (int i = 0; i < listNV.Count; i++)
                {
                    if (maNV.Equals(listNV[i].MaNV.ToString()))
                    {
                        MessageBox.Show("Mã Nhân Viên Đã Tồn Tại!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                //
                DateTime dt = DateTime.Parse(dtpNhanVien.ToString());
                string ngS = dt.ToShortDateString();

                //
                nhanVien.AddDB_TableNhanVien(txtMaNV.Text.ToString(), txtHoNV.Text.ToString(), txtTenNV.Text.ToString(), cobGioiTinh.Text.ToString(), dtpNhanVien.ToString(), txtDiaChiNV.Text.ToString(), txtSDTNV.Text.ToString());

                MessageBox.Show("Thêm Thành Công.", "THÊM", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadListView_NhanVien();
            }
            else
                MessageBox.Show("Có Lỗi!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            //
            DateTime dt = DateTime.Parse(dtpNhanVien.Text.ToString());
            string ngS = dt.ToShortDateString();

            //
            if (!CatchException_NhanVien())
            {
                //
                ListViewItem item = lvNhanVien.SelectedItems[0];
                string maNVOld = item.SubItems[0].Text;

                if (!txtMaNV.Text.Equals(maNVOld))
                {
                    List<DTO_NhanVien> listNV = nhanVien.ReadDB_TableNhanVien();
                    string maNV = txtMaNV.Text;

                    for (int i = 0; i < listNV.Count; i++)
                    {
                        if (maNV.Equals(listNV[i].MaNV.ToString()))
                        {
                            MessageBox.Show("Sửa Trùng Mã Nhân Viên!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                //
                nhanVien.EditDB_TableNhanVien(txtMaNV.Text.ToString(), txtHoNV.Text.ToString(), txtTenNV.Text.ToString(), cobGioiTinh.Text.ToString(), ngS, txtDiaChiNV.Text.ToString(), txtSDTNV.Text.ToString());

                MessageBox.Show("Edit Thành Công.", "SỬA", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadListView_NhanVien();
            }
            else
                MessageBox.Show("Có Lỗi!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (!CatchException_NhanVien())
            {
                nhanVien.RemoveDB_TableNhanVien(txtMaNV.Text.ToString());

                MessageBox.Show("Xoá Thành Công.", "XOÁ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadListView_NhanVien();
            }
            else
                MessageBox.Show("Có Lỗi!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLamMoiNV_Click(object sender, EventArgs e)
        {
            Refresh_TextBoxNV();
        }
      
        //Number Only
        private void txtSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
