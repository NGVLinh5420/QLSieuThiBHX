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
    public partial class FormSanPham : Form
    {
        //
        DAO_SanPham sanPham = new DAO_SanPham();

        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            //Đơn Vị mặc định: CÁI
            cobDonViSP.SelectedItem = "CAI";

            //
            LoadListView_SanPham();

        }

        private void LoadListView_SanPham()
        {
            lvSanPham.Items.Clear();

            //
            List<DTO_SanPham> listSP = sanPham.ReadDB_TableSanPham();
            foreach (var i in listSP)
            {
                ListViewItem item = new ListViewItem(i.MaSP.ToString());
                lvSanPham.Items.Add(item);

                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, i.TenSP.ToString());
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem(item, i.DonViTinhSP.ToString());
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem(item, i.DonGiaSP.ToString());
                item.SubItems.Add(subItem);
            }
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 1)
            {
                ListViewItem item = lvSanPham.SelectedItems[0];
                txtMaSP.Text = item.SubItems[0].Text;
                txtTenSP.Text = item.SubItems[1].Text;
                txtDonGiaSP.Text = item.SubItems[3].Text;

                //if (item.SubItems[2].Text.ToString().Equals("NAM"))

                switch (item.SubItems[2].Text.ToString())
                {
                    case "CAI": cobDonViSP.SelectedItem = "CAI"; break;
                    case "LON": cobDonViSP.SelectedItem = "LON"; break;
                    case "CAY": cobDonViSP.SelectedItem = "CAY"; break;
                    case "TRAI": cobDonViSP.SelectedItem = "TRAI"; break;
                    case "LO": cobDonViSP.SelectedItem = "LO"; break;
                }
            }
            else
            {
                Refresh_TextBoxSP();
            }
        }

        // OTHER
        private bool CatchException_SanPham()
        {
            if (txtMaSP.TextLength != 0 && txtTenSP.TextLength != 0 && txtDonGiaSP.TextLength != 0)
            {
                return false;
            }
            return true;
        }

        public void Refresh_TextBoxSP()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGiaSP.Clear();
            cobDonViSP.SelectedIndex = 0;

            LoadListView_SanPham();
        }

        //Number Only
        private void txtDonGiaSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (!CatchException_SanPham())
            {
                //
                List<DTO_SanPham> listSP = sanPham.ReadDB_TableSanPham();
                string maSP = txtMaSP.Text;

                for (int i = 0; i < listSP.Count; i++)
                {
                    if (maSP.Equals(listSP[i].MaSP.ToString()))
                    {
                        MessageBox.Show("Mã Sản Phẩm Đã Tồn Tại!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                //
                float gia = float.Parse(txtDonGiaSP.Text);
                sanPham.AddDB_TableSanPham(txtMaSP.Text, txtTenSP.Text, cobDonViSP.Items.ToString(), gia);

                MessageBox.Show("Thêm Thành Công.", "THÊM", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadListView_SanPham();
            }
            else MessageBox.Show("Có Lỗi!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (!CatchException_SanPham())
            {
                //
                if (lvSanPham.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Chưa Chọn Sản Phẩm!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ListViewItem item = lvSanPham.SelectedItems[0];
                string maspOld = item.SubItems[0].Text;

                if (!txtMaSP.Text.Equals(maspOld))
                {
                    List<DTO_SanPham> listSP = sanPham.ReadDB_TableSanPham();
                    string maSP = txtMaSP.Text;

                    for (int i = 0; i < listSP.Count; i++)
                    {
                        if (maSP.Equals(listSP[i].MaSP.ToString()))
                        {
                            MessageBox.Show("Sửa Trùng Mã Sản Phẩm!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                //
                float gia = float.Parse(txtDonGiaSP.Text);
                sanPham.EditDB_TableSanPham(txtMaSP.Text, txtTenSP.Text, cobDonViSP.Items.ToString(), gia);

                MessageBox.Show("Sửa Thành Công.", "SỬA", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadListView_SanPham();
            }
            else MessageBox.Show("Có Lỗi!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (!CatchException_SanPham())
            {
                sanPham.RemoveDB_TableSanPham(txtMaSP.Text);

                MessageBox.Show("Xoá Thành Công.", "XOÁ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadListView_SanPham();
            }
            else
                MessageBox.Show("Có Lỗi!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLamMoiSP_Click(object sender, EventArgs e)
        {
            Refresh_TextBoxSP();
        }
    }
}
