using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.ConnectAPI;

namespace WebApplication3.Controllers
{
    public class NCOVController : Controller
    {
        private readonly ICovidConnectAPI _covidConnectAPI;
        public NCOVController(ICovidConnectAPI covidConnectAPI)
        {
            _covidConnectAPI = covidConnectAPI;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _covidConnectAPI.GetAll();
            return View(list);
        }
        public async Task<IActionResult> GetAll()
        {
            var list = await _covidConnectAPI.GetAll();
            return Json(new
            {
                status = true,
                data = list
            });
        }
        public async Task<IActionResult> GetAllLatLong()
        {
            var list = await _covidConnectAPI.GetAllLG();
            return Json(new
            {
                status = true,
                data = list
            });
        }
    }
}
