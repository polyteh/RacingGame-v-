using RacingGameDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RacingGameDAL.Models
{
    public class Engine : IEntity, IName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PowerHP { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int ComponentTypeId { get; set; }
        public ComponentType ComponentType { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
