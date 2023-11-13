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

namespace QLSieuThiBHX
{
    public partial class FormKhachHang : Form
    {
        //
        DAO_KhachHang khachHang = new DAO_KhachHang();

        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadListView_KhachHang();
        }

        // LISTVIEW
        private void lvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count == 1)
            {
                ListViewItem item = lvKhachHang.SelectedItems[0];
                txtMaKH.Text = item.SubItems[0].Text;
                txtHoTenKH.Text = item.SubItems[1].Text;
                txtDiaChiKH.Text = item.SubItems[2].Text;
                txtSDTKH.Text = item.SubItems[3].Text;

                if (item.Text.Equals("KH0"))
                {
                    MessageBox.Show("Không Thể Sửa hay Xoá Khách Hàng Lạ");
                }
            }
            else
            {
                Refresh_TextBoxKH();
            }
        }

        private void LoadListView_KhachHang()
        {
            lvKhachHang.Items.Clear();

            //
            List<DTO_KhachHang> listKH = khachHang.ReadDB_TableKhachHang();
            foreach (var i in listKH)
            {
                ListViewItem item = new ListViewItem(i.MaKH.ToString());
                lvKhachHang.Items.Add(item);

                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, i.HoTenKH.ToString());
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem(item, i.DiaChiKH.ToString());
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem(item, i.SDTKH.ToString());
                item.SubItems.Add(subItem);
            }
        }

        // OTHER
        private bool CatchException_KhachHang()
        {
            if (txtMaKH.TextLength != 0 && txtHoTenKH.TextLength != 0 && txtDiaChiKH.TextLength != 0 && txtSDTKH.TextLength != 0)
            {
                return false;
            }
            return true;
        }

        public void Refresh_TextBoxKH()
        {
            txtMaKH.Clear();
            txtHoTenKH.Clear();
            txtDiaChiKH.Clear();
            txtSDTKH.Clear();

            LoadListView_KhachHang();
        }

        // BUTTON
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            bool flag = false;

            //
            if (!CatchException_KhachHang())
            {
                flag = khachHang.AddDB_TableKhachHang(txtMaKH.Text.ToString(), txtHoTenKH.Text.ToString(),
                txtDiaChiKH.Text.ToString(), txtSDTKH.Text.ToString());
            }

            //
            if (flag)
            {
                MessageBox.Show("Thêm Thành Công.", "THÊM", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadListView_KhachHang();
            }
            else
                MessageBox.Show("Có Lỗi!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            //
            if (!CatchException_KhachHang())
            {
                //
                ListViewItem item = lvKhachHang.SelectedItems[0];
                string maKhOld = item.SubItems[0].Text;

                if (!txtMaKH.Text.Equals(maKhOld))
                {
                    List<DTO_KhachHang> listKH = khachHang.ReadDB_TableKhachHang();
                    string maSP = txtMaKH.Text;

                    for (int i = 0; i < listKH.Count; i++)
                    {
                        if (maSP.Equals(listKH[i].MaKH.ToString()))
                        {
                            MessageBox.Show("Sửa Trùng Mã Khách Hàng!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                //
                khachHang.EditDB_TableKhachHang(txtMaKH.Text.ToString(), txtHoTenKH.Text.ToString(),
                txtDiaChiKH.Text.ToString(), txtSDTKH.Text.ToString());


                MessageBox.Show("Edit Thành Công.", "SỬA", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadListView_KhachHang();
            }
            else
                MessageBox.Show("Có Lỗi!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {

            if (!CatchException_KhachHang())
            {
                khachHang.RemoveDB_TableKhachHang(txtMaKH.Text.ToString());

                MessageBox.Show("Xoá Thành Công.", "XOÁ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadListView_KhachHang();
            }
            else
                MessageBox.Show("Có Lỗi!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLamMoiKH_Click(object sender, EventArgs e)
        {
            Refresh_TextBoxKH();
        }

        //Phone Number Only
        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
