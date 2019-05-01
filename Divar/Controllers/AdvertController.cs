using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Divar.Core.Services;
using Divar.Core.Interfaces;
using Divar.Core.ViewModels;
using Divar.DataAccessLayer.Entities;
using System.Globalization;
using Divar.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc.Rendering;
using Divar.Core.Classes;
using System.IO;

namespace Divar.Controllers
{
    [Authorize]
    public class AdvertController : Controller
    {
        PersianCalendar pc = new PersianCalendar();

        private IAdvert _iavdert;
        private DivarContext _context;

        public AdvertController(IAdvert iadvert, DivarContext context)
        {
            _iavdert = iadvert;
            _context = context;
        }

        public IActionResult AddMark(int advertid, int userid)
        {
            _iavdert.AddMark(advertid, userid);

            return RedirectToAction("Index", "Profile");
        }

        public IActionResult RemoveMark(int id)
        {
            _iavdert.RemoveMark(id);

            return RedirectToAction("Index", "Profile");
        }

        public IActionResult Index()
        {
            var category = _iavdert.ShowCategory();

            return View(category);
        }

        public IActionResult Create(int id)
        {
            ViewBag.CityId = new SelectList(_iavdert.ShowCity(""), "Id", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Create(int id, AdvertViewModel advert)
        {
            if (ModelState.IsValid)
            {
                string strToday = pc.GetYear(DateTime.Now).ToString("0000") + "/" +
                                  pc.GetMonth(DateTime.Now).ToString("00") + "/" +
                                  pc.GetDayOfMonth(DateTime.Now).ToString("00");

                var user = _context.Users.FirstOrDefault(u => u.Mobile == User.Identity.Name);

                Advert ads = new Advert()
                {
                    CityId = advert.CityId,
                    CategoryId = id,
                    Date = strToday,
                    IsExpire = false,
                    Seen = 0,
                    UserId = user.Id,
                    Name = advert.Name,
                    Des = advert.Des
                };

                _iavdert.AddAdvert(ads);

                return RedirectToAction("Index", "Profile");
            }
            else
            {
                return View(advert);
            }
        }

        public IActionResult Delete(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                _iavdert.RemoveAdvert(id);
            }

            return RedirectToAction("Index", "Profile");
        }

        public IActionResult Details(int id)
        {
            return View(_iavdert.DetailAdvert(id));
        }

        public IActionResult Edit(int id)
        {
            var ads = _iavdert.DetailAdvert(id);

            EditAdvertViewModel edit = new EditAdvertViewModel()
            {
                Des = ads.Des,
                Name = ads.Name,
                IsExpire = ads.IsExpire
            };

            return View(edit);
        }

        [HttpPost]
        public IActionResult Edit(EditAdvertViewModel advert, int id)
        {
            if (ModelState.IsValid)
            {
                _iavdert.UpdateAdvert(advert.Name, advert.Des, advert.IsExpire, id);

                return RedirectToAction("Index", "Profile");
            }
            else
            {
                return View(advert);
            }
        }

        public IActionResult ShowAdvertFields(int id)
        {
            var advertField = _iavdert.ShowAdvertFields(id);

            ViewBag.MyId = id;

            return View(advertField);
        }

        public IActionResult AddAdvertField(int id)
        {
            ViewBag.FieldId = new SelectList(_iavdert.ShowCategoryFields(id), "Field.Id", "Field.Name");

            return PartialView();
        }

        [HttpPost]
        public IActionResult AddAdvertField(int id, AddAdvertFieldViewModel addAdvert)
        {
            if (ModelState.IsValid)
            {
                AdvertField advertField = new AdvertField()
                {
                    AdvertId = id,
                    FieldId = addAdvert.FieldId,
                    FieldValue = addAdvert.Value
                };

                _iavdert.AddAdvertField(advertField);

                return Redirect("/Advert/ShowAdvertFields/" + id);
            }
            else
            {
                return PartialView(addAdvert);
            }
        }

        public IActionResult CreateGallery(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateGallery(AddGalleryViewModel addGallery, int id)
        {
            if (ModelState.IsValid)
            {
                string imgPath = "";
                addGallery.ImgName = CodeGenerators.ImgCode() + Path.GetExtension(addGallery.Img.FileName);

                imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/adverts", addGallery.ImgName);

                using (var stream = new FileStream(imgPath, FileMode.Create))
                {
                    addGallery.Img.CopyTo(stream);
                }

                Gallery gallery = new Gallery()
                {
                    AdvertId = id,
                    Img = addGallery.ImgName
                };

                _iavdert.AddGallery(gallery, id);

                return Redirect("/Advert/ShowGallery/" + id);
            }
            else
            { 
                return View(addGallery);
            }            
        }
        
        public IActionResult ShowGallery(int id)
        {
            var gallery = _iavdert.ShowGallery(id);

            ViewBag.MyId = id;

            return View(gallery);
        }

        public IActionResult DeleteGallery(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteGallery(int id)
        {
            if (ModelState.IsValid)
            {
                int advertId = _iavdert.RemoveGallery(id);

                return Redirect("/Advert/ShowGallery/" + advertId);
            }

            return View();
        }

        public IActionResult DeleteAdvertField(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteAdvertField(int id)
        {
            if (ModelState.IsValid)
            {
                int advertId = _iavdert.RemoveAdvertField(id);

                return Redirect("/Advert/ShowAdvertFields/" + advertId);
            }

            return RedirectToAction("Index", "Profile");
        }
    }
}