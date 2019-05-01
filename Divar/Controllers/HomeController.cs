using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Divar.Core.Interfaces;
using Divar.Core.Services;
using Divar.DataAccessLayer.Context;
using System.Globalization;
using System.Net;
using Divar.DataAccessLayer.Entities;

namespace Divar.Controllers
{
    public class HomeController : Controller
    {
        private IAdvert _iadvert;
        private DivarContext _context;

        PersianCalendar pc = new PersianCalendar();

        public HomeController(IAdvert iadvert, DivarContext context)
        {
            _iadvert = iadvert;
            _context = context;
        }

        public IActionResult Index(string strsearch)
        {
            ViewBag.MyString = strsearch;

            return View();
        }

        public IActionResult ShowAdverts(int id, int pageNumber = 1)
        {
            var adverts = _iadvert.ShowAdvertsByCity(id, pageNumber);

            if (adverts.Count() == 0)
            {
                ViewBag.MyCount = 0;
            }
            else
            {
                ViewBag.CityId = id;
                ViewBag.PageId = pageNumber;
                ViewBag.PageCount = adverts.Count();
            }

            return View(adverts);
        }

        //[Route("Adverts/{id}/{title}")]
        public IActionResult Adverts(int id, string title)
        {
            var advert = _iadvert.ShowAdvertById(id);

            if (User.Identity.IsAuthenticated)
            {
                var user = _context.Users.FirstOrDefault(u => u.Mobile == User.Identity.Name);

                if (_iadvert.ExistMark(id, user.Id))
                {
                    ViewBag.IsMark = true;
                }
                else
                {
                    ViewBag.IsMark = false;
                    ViewBag.MyId = user.Id;
                }

                string userIP = null;

                string strToday = pc.GetYear(DateTime.Now).ToString("0000") + "/" +
                                  pc.GetMonth(DateTime.Now).ToString("00") + "/" +
                                  pc.GetDayOfMonth(DateTime.Now).ToString("00");

                userIP = new WebClient().DownloadString("http://icanhazip.com");

                if (_iadvert.ExistVisit(user.Id, id))
                {
                    _iadvert.UpdateVisit(user.Id, id, strToday, DateTime.Now.ToShortTimeString());
                }
                else
                {
                    Visit visit = new Visit()
                    {
                        AddressIP = userIP,
                        AdvertId = id,
                        UserId = user.Id,
                        VisitDate = strToday,
                        VisitTime = DateTime.Now.ToShortTimeString()                       
                    };

                    _iadvert.AddVisit(visit);
                }
            }
            else
            {
                ViewBag.IsMark = false;
            }

            return View(advert);
        }
    }
}