using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using zhtv.Models;

namespace zhtv.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["SongData"] = OrderManager.Instance.SongDatas.Values.ToList();
            ViewData["Playing"] = OrderManager.Instance.PlayingSong;
            ViewData["NextSongs"] = OrderManager.Instance.OrderSongs;
            return View();
        }

        public ActionResult AddOrder(OrderInfo model)
        {
            if (!ModelState.IsValid) return View("Index");
            OrderManager.Instance.OrderSong(model);
            ViewData["SongData"] = OrderManager.Instance.SongDatas.Values.ToList();
            ViewData["Playing"] = OrderManager.Instance.PlayingSong;
            ViewData["NextSongs"] = OrderManager.Instance.OrderSongs;
            return View("Index");
        }

        public ActionResult PlayNextSong()
        {
            OrderManager.Instance.PlayNextSong();
            ViewData["SongData"] = OrderManager.Instance.SongDatas.Values.ToList();
            ViewData["Playing"] = OrderManager.Instance.PlayingSong;
            ViewData["NextSongs"] = OrderManager.Instance.OrderSongs;
            return View("Index");
        }
    }
}
