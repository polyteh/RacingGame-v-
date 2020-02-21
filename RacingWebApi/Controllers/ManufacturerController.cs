using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RacingGameBLL.Interfaces;
using RacingGameDAL.Interfaces;
using RacingGameDAL.Models;
using RacingWebApi.Models;
using Newtonsoft.Json;

namespace RacingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _serv;
        private readonly IMapper _mapper;
        public ManufacturerController(IManufacturerService manufactfServ, IMapper mapper)
        {
            _serv = manufactfServ;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<string> Manufacturer()
        {
            var manufactBLLList = await _serv.GetAllAsync();
            var manufactViewList = ManufacturerView.MapToView(manufactBLLList, _mapper);
            return JsonConvert.SerializeObject(manufactViewList, Formatting.Indented);
        }
        [HttpGet("{id}")]
        public async Task<string> GetById(int id)
        {
            var manufacturerBLLById = await _serv.GetByIdAsync(id);
            if (manufacturerBLLById == null)
                return NotFound().ToString();
            var manufacturerViewById = ManufacturerView.MapToView(manufacturerBLLById, _mapper);
            return JsonConvert.SerializeObject(manufacturerViewById, Formatting.Indented); ;
        }
        [HttpPost]
        public async Task<bool> Post(ManufacturerView manufacturer)
        {
            if (manufacturer==null)
            {
                return false;
            }
            if (ModelState.IsValid)
            {
                var manufacturereBLL = ManufacturerView.MapToBLL(manufacturer, _mapper);
                var postResult = await _serv.AddAsync(manufacturereBLL);
                return postResult;
            }
            return false;

        }
    }

}