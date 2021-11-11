using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EShop.Models;

namespace EShop.Models
{
    public class InvoiceDetail
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Mã hoá đơn"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public int InvoiceId { get; set; }

        public Invoice Invoice { get; set; }

        [DisplayName("Mã sản phẩm"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [DisplayName("Số lượng"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        [MinLength(1,ErrorMessage ="{0} ít nhất là 1")]
        public int Quantity { get; set; }

        [DisplayName("Giá bán mỗi sản phẩm"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        [MinLength(0, ErrorMessage = "{0} ít nhất là 0")]
        public int UnitPrice { get; set; }
    }
}
