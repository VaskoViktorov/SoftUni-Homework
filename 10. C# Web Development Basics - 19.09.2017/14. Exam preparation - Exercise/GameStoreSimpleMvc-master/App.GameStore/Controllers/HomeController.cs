using System;
using System.Collections.Generic;
using System.Text;
using SimpleMvc.Framework.Contracts;

namespace App.GameStore.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
            => this.View();
    }
}
