﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WisdomDuck.Models;

namespace WisdomDuck.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["wisdom"] = DispenseWisdom();
            return View();
        }

        [Route("/wisdom")]
        public IActionResult Wisdom()
        {
            ViewData["wisdom"] = DispenseWisdom();
            return View();
        }

        private readonly List<string> Subject = new List<string>
        {
            "Duck",
            "He",
            "They",
            "It",
            "She",
            "That",
            "Wisdom",
            "You"
        };

        private readonly List<string> Verb = new List<string>
        {
            "perceives",
            "understands",
            "values",
            "exemplifies",
            "is",
            "has",
            "delivers",
            "provides",
            "consumes",
            "abolishes",
            "accelerates",
            "achieves",
            "acts with"
        };

        private readonly List<string> Noun = new List<string>
        {
            "friendship",
            "kindness",
            "compassion",
            "love",
            "care",
            "entertainment",
            "judgement",
            "jurisdiction",
            "beauty",
            "play",
            "art",
            "understanding",
            "knowledge",
            "theory",
            "power",
            "development",
            "strategy"
        };

        private string DispenseWisdom()
        {
            Random rnd = new Random();

            return $"{Subject[rnd.Next(0, Subject.Count)]} {Verb[rnd.Next(0, Verb.Count)]} {Noun[rnd.Next(0, Noun.Count)]}";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
