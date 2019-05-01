using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Divar.Core.Interfaces;
using Divar.Core.Services;

namespace Divar.ViewComponents.MarkComponent
{
    public class MarkComponent : ViewComponent
    {
        private IAdvert _iadvert;

        public MarkComponent(IAdvert iadvert)
        {
            _iadvert = iadvert;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return await Task.FromResult((IViewComponentResult)View("ShowMarks", _iadvert.ShowUserMark(id)));
        }
    }
}
