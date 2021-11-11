using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EShop.Models;

namespace EShop.Models
{
    [Index(nameof(Email), nameof(Phone), IsUnique = true, Name = "account_Unique")]
    public class Account
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Tên đăng nhập")]
        [StringLength(20,MinimumLength =6,ErrorMessage ="{0} có 6-20 kí tự!")]
        [Required(ErrorMessage = "{0} bị bỏ trống!")]
        public String Username { get; set; }

        [DisplayName("Mật khẩu")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} có 6-20 kí tự!")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} bị bỏ trống!")]
        public String Password { get; set; }

        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} bị bỏ trống!")]
        public String Email { get; set; }

        [DisplayName("Số điện thoại")]
        [RegularExpression("0\\d{9}",ErrorMessage = "{0} không hợp lệ!")]
        [Required(ErrorMessage = "{0} bị bỏ trống!")]
        public String Phone { get; set; }

        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "{0} bị bỏ trống!")]
        public String Address { get; set; }

        [DisplayName("Họ tên")]
        [Required(ErrorMessage = "{0} bị bỏ trống!")]
        public String FullName { get; set; }

        [DisplayName("Là Admin")]
        [Required(ErrorMessage = "{0} bị bỏ trống!")]
        public bool IsAdmin { get; set; }

        [DisplayName("Ảnh đại diện")]
        [Required(ErrorMessage = "{0} bị bỏ trống!")]
        public String Avatar { get; set; }

        [DisplayName("Trạng thái")]
        public bool Status { get; set; }

        public List<Invoice> Invoices { get; set; }

        public List<Cart> Carts { get; set; }

    }
}
