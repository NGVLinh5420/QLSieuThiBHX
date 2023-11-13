using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThiBHX.DTO
{
    internal class DTO_SP_SoLuong
    {
        private string _MaSP;
        private string _TenSP;
        private int _TongSoLuong;

        public DTO_SP_SoLuong(string maSP, string tenSP, int tongSoLuong)
        {
            _MaSP = maSP;
            _TenSP = tenSP;
            _TongSoLuong = tongSoLuong;
        }

        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public int TongSoLuong { get => _TongSoLuong; set => _TongSoLuong = value; }

        //METHOD
        public DTO_SP_SoLuong(DataRow row)
        {
            MaSP = row["MaSP"].ToString();
            TenSP = row["TenSP"].ToString();
            TongSoLuong = int.Parse(row["TongSoLuong"].ToString());
        }
    }
}
