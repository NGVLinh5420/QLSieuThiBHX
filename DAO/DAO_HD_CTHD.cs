using QLSieuThiBHX.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThiBHX.DAO
{
    internal class DAO_HD_CTHD
    {
        public DAO_HD_CTHD() { }

        //
        private static DAO_HD_CTHD _instance;
        public static DAO_HD_CTHD Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DAO_HD_CTHD();
                }
                return _instance;
            }
        }

        /*
         * Đọc CSDL, Tạo List Hoá Đơn từ Table.HoaDon
         */
        public List<DTO_HoaDon> ReadDB_TableHoaDon()
        {
            List<DTO_HoaDon> listHD = new List<DTO_HoaDon>();

            string query = "EXEC HD_READ_HOADON";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                DTO_HoaDon hd = new DTO_HoaDon(row);
                listHD.Add(hd);
            }
            return listHD;
        }

        /*
         * Đọc CSDL, Tạo List Chi Tiết Hoá Đơn từ Table.HoaDon
         */
        public List<DTO_ChiTietHD> ReadDB_TableChiTietHD()
        {
            List<DTO_ChiTietHD> listCTHD = new List<DTO_ChiTietHD>();

            string query = "EXEC CTHD_READ_CHITIETHD";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                DTO_ChiTietHD ctHD = new DTO_ChiTietHD(row);
                listCTHD.Add(ctHD);
            }
            return listCTHD;
        }

        /*
         * Đọc CSDL, Tạo List Hoá Đơn + Giá từ PROC SP_READ_SELECT_HD_GIA
         */
        public List<DTO_HD_Gia> ReadDB_Select_HD_Gia()
        {
            List<DTO_HD_Gia> listHD_Gia = new List<DTO_HD_Gia>();

            string query = "EXEC SP_READ_SELECT_HD_GIA";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                DTO_HD_Gia hd_gia = new DTO_HD_Gia(row);
                listHD_Gia.Add(hd_gia);
            }
            return listHD_Gia;
        }

        /*
         * Đọc CSDL, Tạo List Sản Phẩm + Số Lượng từ PROC SP_READ_SELECT_SP_SOLUONG
         */
        public List<DTO_SP_SoLuong> ReadDB_Select_SP_SoLuong()
        {
            List<DTO_SP_SoLuong> listSP_SL = new List<DTO_SP_SoLuong>();

            string query = "EXEC SP_READ_SELECT_SP_SOLUONG";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                DTO_SP_SoLuong sp_sl = new DTO_SP_SoLuong(row);
                listSP_SL.Add(sp_sl);
            }
            return listSP_SL;
        }

        /*
         * Thêm Hoá Đơn cho Table.HoaDon
         */
        public bool AddDB_TableHoaDon(string ma, string ten, string dvt, float dg)
        {
            string query = "SP_ADD_SANPHAM @MaSP , @TenSP , @DonViTinh , @DonGia";
            object[] param = new object[] { ma, ten, dvt, dg };
            int result = DataProvider.Instance.ExecuteNonQuery(query, param);
            return result > 0;
        }

        /*
         * Cập Nhật-Update tt Hoá Đơn cho Table.HoaDon
         */
        public bool EditDB_TableHoaDon(string ma, string ten, string dvt, float dg)
        {
            string query = "SP_UPDATE_SANPHAM @MaSP , @TenSP , @DonViTinh , @DonGia";
            object[] param = new object[] { ma, ten, dvt, dg };
            int result = DataProvider.Instance.ExecuteNonQuery(query, param);
            return result > 0;
        }

        /*
         * Xoá Hoá Đơn Khỏi Table.HoaDon
         */
        public bool RemoveDB_TableHoaDon(string ma)
        {
            string query = "SP_DELETE_HOADON @MaSP";
            object[] param = new object[] { ma };
            int result = DataProvider.Instance.ExecuteNonQuery(query, param);
            return result > 0;
        }
    }
}
