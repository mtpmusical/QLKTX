using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KTX.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required (ErrorMessage = "Nguyên óc cho")]
        public string TenDangNhap { get; set; }
        [Required(ErrorMessage = "Nguyên óc cho")]
        public string MatKhau { get; set; }
        

    }
}