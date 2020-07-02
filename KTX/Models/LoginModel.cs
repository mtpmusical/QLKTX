using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KTX.Models
{
    public class LoginModel
    {
        [Required (ErrorMessage = "Nguyên óc cho")]
        public string TenDangNhap { get; set; }
        [Required(ErrorMessage = "Nguyên óc cho")]
        public string MatKhau { get; set; }

        public string MaNV { get; set; }
        public string HoTenNV { get; set; }
        public int? ChucVu { get; set; }

    }
}