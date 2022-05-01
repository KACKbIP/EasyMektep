using EasyMektep.Interfaces;
using EasyMektep.Models.Statistics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyMektep.Controllers
{
    [Authorize]
    public class StatisticsController : Controller
    {
        private readonly IStatisticsInterface _repository;
        public StatisticsController(IStatisticsInterface repository)
        {
            this._repository = repository;
        }
        public IActionResult Index()
        {
            StatisticsModel model = new StatisticsModel();
            model = _repository.GetStatistics();
            return View(model);
        }
    }
}
