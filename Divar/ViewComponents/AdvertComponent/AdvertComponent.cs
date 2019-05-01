using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Divar.Core.Interfaces;
using Divar.Core.Services;
using Divar.DataAccessLayer.Context;

namespace Divar.ViewComponents.AdvertComponent
{
    public class AdvertComponent : ViewComponent
    {
        private IAdvert _iadvert;
        private DivarContext _context;

        public AdvertComponent(IAdvert iadvert, DivarContext context)
        {
            _iadvert = iadvert;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = _context.Users.FirstOrDefault(u => u.Mobile == User.Identity.Name);

            return await Task.FromResult((IViewComponentResult)View("ShowAdverts", _iadvert.ShowAdvert(user.Id)));
        }
    }
}
