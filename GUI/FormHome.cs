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
            FormHoaDon formHoaDon = new FormHoaDon();

            

            if (Application.OpenForms.Count > 1)
            {
                Form openningForm = Application.OpenForms[1];

                string msg = "Đóng Ngay Cửa Sổ Đang Mở!!";
                DialogResult result = MessageBox.Show(msg, "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    openningForm.Close();

                    formHoaDon.MdiParent = this;
                    formHoaDon.Show();
                }
                else return;
            }

            //
            formHoaDon.MdiParent = this;
            formHoaDon.Show();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            labelBHX.Visible = false;

            if (Application.OpenForms.Count > 1)
            {
                string msg = "Có cửa sổ chưa đóng!! \nNếu tắt chương trình ngay, bạn sẽ có thể sẽ mất dữ liệu (!) \nBạn có chắc chắn muốn thoát chương trình?";
                DialogResult result = MessageBox.Show(msg, "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    e.Cancel = true;
            }

            //MessageBox.Show("Hãy Đóng Cửa Sổ Đang Mở!!");
            //return;
        }
    }
}
