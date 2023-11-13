using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThiBHX.DTO
{
    internal class DTO_NhanVien
    {
        private string _MaNV;
        private string _HoNV;
        private string _TenNV;
        private string _GioiTinhNV;
        private string _NgSNV;
        private string _DiaChiNV;
        private string _SDTNV;

        public DTO_NhanVien(string maNV, string hoNV, string tenNV, string gioiTinhNV, string ngSNV, string diaChiNV, string sDTNV)
        {
            _MaNV = maNV;
            _HoNV = hoNV;
            _TenNV = tenNV;
            _GioiTinhNV = gioiTinhNV;
            _NgSNV = ngSNV;
            _DiaChiNV = diaChiNV;
            _SDTNV = sDTNV;
        }

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string HoNV { get => _HoNV; set => _HoNV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public string GioiTinhNV { get => _GioiTinhNV; set => _GioiTinhNV = value; }
        public string NgSNV { get => _NgSNV; set => _NgSNV = value; }
        public string DiaChiNV { get => _DiaChiNV; set => _DiaChiNV = value; }
        public string SDTNV { get => _SDTNV; set => _SDTNV = value; }

        //METHOD
        public DTO_NhanVien(DataRow row)
        {
            MaNV = row["MaNV"].ToString();
            HoNV = row["HoNV"].ToString();
            TenNV = row["TenNV"].ToString();
            GioiTinhNV = row["GioiTinh"].ToString();
            NgSNV = row["NgaySinh"].ToString();
            DiaChiNV = row["DiaChi"].ToString();
            SDTNV = row["DienThoai"].ToString();
        }
    }
}
