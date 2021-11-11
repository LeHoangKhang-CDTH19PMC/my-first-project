using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EShop.Models;

namespace EShop.Models
{
    public class Cart
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Mã tài khoản"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public int AccountId { get; set; }

        public Account Account { get; set; }

        [DisplayName("Mã sản phẩm"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [DisplayName("Số lượng"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        [MinLength(1,ErrorMessage ="{0} ít nhất là 1")]
        public int Quantity { get; set; }
    }
}
