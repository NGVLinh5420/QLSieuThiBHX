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
        //
        Form formOpenning; //Đối tượng lưu một-hoặc-nhiều form đang mở ở hiện tại

        public FormHome()
        {
            InitializeComponent();
        }

        private void msiNhanVien_Click(object sender, EventArgs e)
        {
            //
            msQuanLy.BackColor = Color.Yellow;
            labelBHX.Visible = false; //Khi mở form child, dòng chữ BHX sẽ ẩn đi.

            //
            FormNhanVien formNhanVien = new FormNhanVien();

            //Bắt lỗi
            if (Application.OpenForms.Count > 1) //Hoặc cho '== 1'
            {
                formOpenning = Application.OpenForms[1]; /* Mặc định chỉ cho phép mở 1-WindowChild[1] trong WindowMDI[0]
                                                          * Gán formOpenning => form đang mở hiện tại
                                                          */

                string msg = "Có Cửa Sổ Khác Đang Mở. \nĐóng Nó Lại Và Mở Cửa Sổ Mới?";
                DialogResult result = MessageBox.Show(msg, "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) //Nhấn YES -> Đóng Window //Nhấn NO -> Không làm gì.
                {
                    formOpenning.Close();
                }
                else return;

            }
            else


                //
                formNhanVien.MdiParent = this;
            formNhanVien.Show();

        }

        private void msiKhachHang_Click(object sender, EventArgs e)
        {
            //
            msQuanLy.BackColor = Color.Yellow;
            labelBHX.Visible = false; //Khi mở form child, dòng chữ BHX sẽ ẩn đi.

            //
            FormKhachHang formKhachHang = new FormKhachHang();

            //Bắt lỗi
            if (Application.OpenForms.Count > 1) //Hoặc cho '== 1'
            {
                formOpenning = Application.OpenForms[1]; /* Mặc định chỉ cho phép mở 1-WindowChild[1] trong WindowMDI[0]
                                                          * Gán formOpenning => form đang mở hiện tại
                                                          */

                string msg = "Có Cửa Sổ Khác Đang Mở. \nĐóng Nó Lại Và Mở Cửa Sổ Mới?";
                DialogResult result = MessageBox.Show(msg, "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) //Nhấn YES -> Đóng Window //Nhấn NO -> Không làm gì.
                {
                    formOpenning.Close();
                }
                else return;

            }


            //
            formKhachHang.MdiParent = this;
            formKhachHang.Show();

        }

        private void msiSanPham_Click(object sender, EventArgs e)
        {
            //
            msQuanLy.BackColor = Color.Yellow;

            //
            FormSanPham formSanPham = new FormSanPham();

            //Bắt lỗis
            if (Application.OpenForms.Count > 1) //Hoặc cho '== 1'
            {
                formOpenning = Application.OpenForms[1]; /* Mặc định chỉ cho phép mở 1-WindowChild[1] trong WindowMDI[0]
                                                          * Gán formOpenning => form đang mở hiện tại
                                                          */

                string msg = "Có Cửa Sổ Khác Đang Mở. \nĐóng Nó Lại Và Mở Cửa Sổ Mới?";
                DialogResult result = MessageBox.Show(msg, "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) //Nhấn YES -> Đóng Window //Nhấn NO -> Không làm gì.
                {
                    formOpenning.Close();
                }
                else return;
            }

            //
            formSanPham.MdiParent = this;
            formSanPham.Show();
        }

        private void msiHoaDon_Click(object sender, EventArgs e)
        {
            //
            msQuanLy.BackColor = Color.Yellow;
            labelBHX.Visible = false; //Khi mở form child, dòng chữ BHX sẽ ẩn đi.

            //
            FormHoaDon formHoaDon = new FormHoaDon();

            //Bắt lỗi
            if (Application.OpenForms.Count > 1) //Hoặc cho '== 1'
            {
                formOpenning = Application.OpenForms[1]; /* Mặc định chỉ cho phép mở 1-WindowChild[1] trong WindowMDI[0]
                                                          * Gán formOpenning => form đang mở hiện tại
                                                          */

                string msg = "Có Cửa Sổ Khác Đang Mở. \nĐóng Nó Lại Và Mở Cửa Sổ Mới?";
                DialogResult result = MessageBox.Show(msg, "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) //Nhấn YES -> Đóng Window //Nhấn NO -> Không làm gì.
                {
                    formOpenning.Close();
                }
                else return;
            }

            //
            formHoaDon.MdiParent = this;
            formHoaDon.Show();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                string msg = "Có cửa sổ chưa đóng!! \nNếu tắt chương trình ngay, bạn sẽ có thể sẽ mất dữ liệu (!) \nBạn có chắc chắn muốn thoát chương trình?";
                DialogResult result = MessageBox.Show(msg, "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) //Nhấn YES -> Đóng Window //Nhấn NO -> Không làm gì.
                    e.Cancel = false;
                else CatchException();
            }
        }

        //Catch E
        private void CatchException()
        {
            MessageBox.Show("'?'", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Nếu đóng hết cửa sổ con, set GUI lại như cũ
        private void FormHome_MdiChildActivate(object sender, EventArgs e)
        {
            labelBHX.Visible = false; //Khi mở form child, dòng chữ BHX sẽ ẩn đi.

            if (Application.OpenForms.Count == 1) labelBHX.Visible = true;
        }
    }
}
