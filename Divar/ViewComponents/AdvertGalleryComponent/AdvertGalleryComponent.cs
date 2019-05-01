using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Divar.Core.Interfaces;
using Divar.Core.Services;
using Divar.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace Divar.ViewComponents.AdvertGalleryComponent
{
    public class AdvertGalleryComponent : ViewComponent
    {
        private IAdvert _iadvert;

        public AdvertGalleryComponent(IAdvert iadvert)
        {
            _iadvert = iadvert;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return await Task.FromResult((IViewComponentResult)View("ShowAdvertGallery", _iadvert.ShowGallery(id)));
        }
    }
}
