using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EShop.Models;

namespace EShop.Models
{
    public class Invoice
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Mã code"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public String Code { get; set; }

        [DisplayName("Mã tài khoản"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public int AccountId { get; set; }

        public Account Account { get; set; }

        [DisplayName("Ngày lập"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        [DataType(DataType.Date)]
        public DateTime IssuedDate { get; set; }

        [DisplayName("Địa chỉ giao hàng"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public String ShippingAddress { get; set; }

        [DisplayName("Số điện thoại giao hàng"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        [RegularExpression("0\\d{9}", ErrorMessage ="{0} không hợp lệ!")]
        public String ShippingPhone { get; set; }

        [DisplayName("Tổng tiền"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public int Total { get; set; }

        [DisplayName("Trạng thái")]
        public bool Status { get; set; }

        public List<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
