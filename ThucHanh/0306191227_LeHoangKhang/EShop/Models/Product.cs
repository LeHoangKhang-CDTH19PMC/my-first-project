using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EShop.Models;

namespace EShop.Models
{
    public class Product
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("SKU"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public String SKU { get; set; }

        [DisplayName("Tên sản phẩm"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public String Name { get; set; }

        [DisplayName("Mô tả"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public String Description { get; set; }

        [DisplayName("Giá bán"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public int Price { get; set; }

        [DisplayName("Tồn kho"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public int Stock { get; set; }

        [DisplayName("ID loại sản phẩm"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public int ProductTypeId { get; set; }

        public ProductType ProductType { get; set; }

        [DisplayName("Hình ảnh"), Required(ErrorMessage = "{0} bị bỏ trống!")]
        public String Image { get; set; }

        [DisplayName("Trạng thái")]
        public bool Status { get; set; }

        public List<InvoiceDetail> InvoiceDetails { get; set; }

        public List<Cart> Carts { get; set; }
    }
}
