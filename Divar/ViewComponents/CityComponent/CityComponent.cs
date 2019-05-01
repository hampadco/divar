using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Divar.Core.Interfaces;
using Divar.Core.Services;

namespace Divar.ViewComponents.CityComponent
{
    public class CityComponent : ViewComponent
    {
        private IAdvert _iadvert;

        public CityComponent(IAdvert iadvert)
        {
            _iadvert = iadvert;
        }

        public async Task<IViewComponentResult> InvokeAsync(string strsearch)
        {
            if (!String.IsNullOrEmpty(strsearch))
            {
                return await Task.FromResult((IViewComponentResult)View("ShowCities", _iadvert.ShowCity(strsearch)));
            }
            else
            {
                return await Task.FromResult((IViewComponentResult)View("ShowCities", _iadvert.ShowCity("")));
            }
        }
    }
}
