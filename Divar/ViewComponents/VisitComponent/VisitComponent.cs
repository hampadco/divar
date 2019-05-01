using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Divar.DataAccessLayer.Context;
using Divar.Core.Interfaces;
using Divar.Core.Services;

namespace Divar.ViewComponents.VisitComponent
{
    public class VisitComponent : ViewComponent
    {
        private IAdvert _iadvert;

        public VisitComponent(IAdvert iadvert)
        {
            _iadvert = iadvert;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return await Task.FromResult((IViewComponentResult)View("ShowVisit", _iadvert.ShowUserVisits(id)));
        }
    }
}
