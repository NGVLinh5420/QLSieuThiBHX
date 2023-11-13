using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThiBHX.DTO
{
    internal class DTO_SanPham
    {
        private string _MaSP;
        private string _TenSP;
        private string _DonViTinhSP;
        private float _DonGiaSP;

        public DTO_SanPham(string maSP, string tenSP, string donViTinhSP, float donGiaSP)
        {
            _MaSP = maSP;
            _TenSP = tenSP;
            _DonViTinhSP = donViTinhSP;
            _DonGiaSP = donGiaSP;
        }

        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public string DonViTinhSP { get => _DonViTinhSP; set => _DonViTinhSP = value; }
        public float DonGiaSP { get => _DonGiaSP; set => _DonGiaSP = value; }

        //METHOD
        public DTO_SanPham(DataRow row)
        {
            MaSP = row["MaSP"].ToString();
            TenSP = row["TenSP"].ToString();
            DonViTinhSP = row["DonViTinh"].ToString();
            DonGiaSP = float.Parse(row["DonGia"].ToString());
        }
    }
}
