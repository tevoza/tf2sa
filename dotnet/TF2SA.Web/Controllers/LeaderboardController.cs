using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TF2SA.Data.Repositories.Base;
using TF2SA.Data.Entities.MariaDb;
using TF2SA.Data.Services.Base;
using TF2SA.Data.Models;

namespace TF2SA.Web.Controllers
{
    public class LeaderboardController : Controller
    {
        private readonly ILogger<LeaderboardController> _logger;
        private readonly IStatsService statsService;

        public LeaderboardController(ILogger<LeaderboardController> logger, IStatsService statsService)
        {
            _logger = logger;
            this.statsService = statsService;
        }

        public IActionResult AllTime()
        {
            var playerStats = statsService.AllTimeStats();
            return View(playerStats);
        }

        public IActionResult Recent()
        {
            var playerStats = statsService.RecentStats();
            return View(playerStats);
        }

        public IActionResult ScoutAllTime()
        {
            var scoutStats = statsService.ScoutStatsAllTime();
            return View(scoutStats);
        }

        public IActionResult ScoutRecent()
        {
            var scoutStats = statsService.ScoutStatsRecent();
            return View(scoutStats);
        }

        public IActionResult SoldierRecent()
        {
            var soldierStats = statsService.SoldierStatsRecent();
            return View(soldierStats);
        }

        public IActionResult SoldierAllTime()
        {
            var soldierStats = statsService.SoldierStatsAllTime();
            return View(soldierStats);
        }

        public IActionResult DemomanRecent()
        {
            var demoStats = statsService.DemomanStatsRecent();
            return View(demoStats);
        }

        public IActionResult DemomanAllTime()
        {
            var demoStats = statsService.DemomanStatsAllTime();
            return View(demoStats);
        }

        public IActionResult MedicAllTime()
        {
            var medicStats = statsService.MedicStatsAllTime();
            return View(medicStats);
        }

        public IActionResult MedicRecent()
        {
            var medicStats = statsService.MedicStatsRecent();
            return View(medicStats);
        }

    }
}