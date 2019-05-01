using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Divar.DataAccessLayer.Entities;
using Divar.Core.Interfaces;
using Divar.Core.Services;

namespace Divar.ViewComponents.FirstImageComponent
{
    public class FirstImageComponent : ViewComponent
    {
        private IAdvert _iadvert;

        public FirstImageComponent(IAdvert iadvert)
        {
            _iadvert = iadvert;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return await Task.FromResult((IViewComponentResult)View("ShowFirstImage", _iadvert.FirstAdvertImage(id)));
        }
    }
}
