using System;
using System.Collections.Generic;
using System.Text;

namespace RacingGameBLL.Models
{
    public class EngineBLL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PowerHP { get; set; }
        public decimal Price { get; set; }
        public int ComponentTypeId { get; set; }
        public ComponentTypeBLL ComponentType { get; set; }
        public int ManufacturerId { get; set; }
        public ManufacturerBLL Manufacturer { get; set; }
    }
}
