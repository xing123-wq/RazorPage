using _17bnag.Pages;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _17bnag.View_Component
{
    public class _Keyword : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DefaultModel model = new DefaultModel();
            return View(model.Default());
        }

    }
}

