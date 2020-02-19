using RacingGameDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RacingGameDAL.Models
{
    public class ComponentType : IEntity, IName
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
