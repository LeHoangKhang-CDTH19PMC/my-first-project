using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EShop.Models;

namespace EShop.Models
{
    public class ProductType
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Tên loại sản phẩm"), Required(ErrorMessage ="{0} bị bỏ trống!")]
        public String Name { get; set; }

        [DisplayName("Trạng thái")]
        public bool Status { get; set; }

        public List<Product> Products { get; set; }
    }
}
