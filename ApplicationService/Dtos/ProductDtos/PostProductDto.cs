using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ServiceModels
{
    public class PostProductDto
    {
        public int Code { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
