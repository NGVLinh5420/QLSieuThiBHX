using QLSieuThiBHX.DAO;
using QLSieuThiBHX.DTO;
using QLSieuThiBHX.GUI;
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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void msiNhanVien_Click(object sender, EventArgs e)
        {
            //
            labelBHX.Visible = false;

            if (Application.OpenForms.Count > 1)
            {
                MessageBox.Show("Hãy Đóng Cửa Sổ Đang Mở!!");
                return;
            }

            //
            FormNhanVien nv = new FormNhanVien();
            nv.MdiParent = this;
            nv.Show();

        }

        private void msiKhachHang_Click(object sender, EventArgs e)
        {
            //
            labelBHX.Visible = false;

            if (Application.OpenForms.Count > 1)
            {
                MessageBox.Show("Hãy Đóng Cửa Sổ Đang Mở!!");
                return;
            }

            //
            FormKhachHang formKhachHang = new FormKhachHang();
            formKhachHang.MdiParent = this;
            formKhachHang.Show();
        }

        private void msiSanPham_Click(object sender, EventArgs e)
        {
            //
            labelBHX.Visible = false;

            if (Application.OpenForms.Count > 1)
            {
                MessageBox.Show("Hãy Đóng Cửa Sổ Đang Mở!!");
                return;
            }

            //
            FormSanPham formSanPham = new FormSanPham();
            formSanPham.MdiParent = this;
            formSanPham.Show();
        }

        private void msiHoaDon_Click(object sender, EventArgs e)
        {
            //
            labelBHX.Visible = false;

            if (Application.OpenForms.Count > 1)
            {
                MessageBox.Show("Hãy Đóng Cửa Sổ Đang Mở!!");
                return;
            }

            //
            FormHoaDon formHoaDon = new FormHoaDon();
            formHoaDon.MdiParent = this;
            formHoaDon.Show();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            labelBHX.Visible = false;

            if (Application.OpenForms.Count > 1)
            {
                MessageBox.Show("Hãy Đóng Cửa Sổ Đang Mở!!");
                return;
            }

            //
            //string msg = "Bạn có chắc chắn muốn thoát chương trình ?";
            //var result = MessageBox.Show(msg, "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result != DialogResult.Yes)
            //    e.Cancel = true;
        }
    }
}
