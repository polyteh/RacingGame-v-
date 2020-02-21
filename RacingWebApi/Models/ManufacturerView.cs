using AutoMapper;
using RacingGameBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RacingWebApi.Models
{
    public class ManufacturerView
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static IEnumerable<ManufacturerBLL> MapToBLL(IEnumerable<ManufacturerView> viewList, IMapper imapper)
        {
            return imapper.Map<IEnumerable<ManufacturerBLL>>(viewList);
        }
        public static ManufacturerBLL MapToBLL(ManufacturerView viewItem, IMapper imapper)
        {
            return imapper.Map<ManufacturerBLL>(viewItem);
        }
        public static IEnumerable<ManufacturerView> MapToView(IEnumerable<ManufacturerBLL> bllList, IMapper imapper)
        {
            return imapper.Map<IEnumerable<ManufacturerView>>(bllList);
        }
        public static ManufacturerView MapToView(ManufacturerBLL bllitem, IMapper imapper)
        {
            return imapper.Map<ManufacturerView>(bllitem);
        }

    }
}
