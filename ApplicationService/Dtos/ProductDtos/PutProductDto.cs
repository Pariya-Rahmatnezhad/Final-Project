using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationService.Dtos.ProductDtos
{
    public class PutProductDto
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
