﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace CSharpApp.Controllers 
{
    public class CloseController : Controller
    {
        private IHostApplicationLifetime ApplicationLifetime { get; set; }
        public CloseController(IHostApplicationLifetime appLifetime)
        {
            ApplicationLifetime = appLifetime;
        }
        public IActionResult Index()
        {
            ApplicationLifetime.StopApplication();
            return View();
        }
    }
}

