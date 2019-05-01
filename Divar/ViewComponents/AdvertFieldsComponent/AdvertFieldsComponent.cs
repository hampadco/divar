using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Divar.DataAccessLayer.Entities;
using Divar.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Divar.Core.Interfaces;
using Divar.Core.Services;

namespace Divar.ViewComponents.AdvertFieldsComponent
{
    public class AdvertFieldsComponent : ViewComponent
    {
        private IAdvert _iadvert;

        public AdvertFieldsComponent(IAdvert iadvert)
        {
            _iadvert = iadvert;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return await Task.FromResult((IViewComponentResult)View("ShowAdvertFields", _iadvert.ShowAdvertFields(id)));
        }
    }
}
