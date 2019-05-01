using System;
using System.Collections.Generic;
using System.Text;
using Divar.Core.Interfaces;
using Divar.DataAccessLayer.Entities;
using Divar.DataAccessLayer.Context;
using System.Linq;
using Divar.Core.Classes;
using Divar.Core.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Divar.Core.Services
{
    public class AdvertService : IAdvert
    {
        DivarContext _context;

        public AdvertService(DivarContext context)
        {
            _context = context;
        }

        public int AddAdvert(Advert advert)
        {
            _context.Adverts.Add(advert);

            _context.SaveChanges();

            return advert.Id;
        }

        public int AddAdvertField(AdvertField advertField)
        {
            _context.AdvertFields.Add(advertField);

            _context.SaveChanges();

            return advertField.Id;
        }

        public int AddGallery(Gallery gallery, int id)
        {
            _context.Galleries.Add(gallery);

            _context.SaveChanges();

            return gallery.Id;
        }

        public int AddMark(int advertid, int userid)
        {
            Mark mark = new Mark()
            {
                AdvertId = advertid,
                UserId = userid
            };

            _context.Marks.Add(mark);
            _context.SaveChanges();

            return mark.Id;
        }

        public int AddVisit(Visit visit)
        {
            _context.Visits.Add(visit);

            _context.SaveChanges();

            return visit.Id;
        }

        public Advert DetailAdvert(int id)
        {
            var advert = _context.Adverts.Find(id);

            return advert;
        }

        public bool ExistMark(int advertid, int userid)
        {
            if (_context.Marks.Any(m => m.AdvertId == advertid && m.UserId == userid))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ExistVisit(int userid, int advertid)
        {
            return _context.Visits.Any(v => v.UserId == userid && v.AdvertId == advertid);
        }

        public Gallery FirstAdvertImage(int id)
        {
            return _context.Galleries.FirstOrDefault(g => g.AdvertId == id);
        }

        public bool RemoveAdvert(int id)
        {
            var ads = _context.Adverts.Find(id);

            _context.Remove(ads);

            _context.SaveChanges();

            return true;
        }

        public int RemoveAdvertField(int id)
        {
            var advertField = _context.AdvertFields.Find(id);

            _context.Remove(advertField);

            _context.SaveChanges();

            return advertField.AdvertId;
        }

        public int RemoveGallery(int id)
        {
            var gallery = _context.Galleries.Find(id);

            _context.Remove(gallery);

            _context.SaveChanges();

            return gallery.AdvertId;
        }

        public bool RemoveMark(int id)
        {
            var mark = _context.Marks.Find(id);

            _context.Remove(mark);

            _context.SaveChanges();

            return true;
        }

        public List<Advert> ShowAdvert(int userId)
        {
            return _context.Adverts.Where(a => a.UserId == userId).OrderByDescending(a => a.Date).ToList();
        }

        public Advert ShowAdvertById(int id)
        {
            var advert = _context.Adverts.Include(a => a.User).FirstOrDefault(a => a.Id == id);

            advert.Seen += 1;

            _context.SaveChanges();

            return advert;
        }

        public List<AdvertField> ShowAdvertFields(int id)
        {
            return _context.AdvertFields.Include(a => a.Field).Where(a => a.AdvertId == id).ToList();
        }

        public List<Advert> ShowAdvertsByCity(int id, int pageNumber)
        {
            int skip = (pageNumber - 1) * 4;

            return _context.Adverts.Include(a => a.Category).Where(a => a.CityId == id && a.IsExpire == false).OrderByDescending(a => a.Id).Skip(skip).Take(4).ToList();
        }

        public List<Category> ShowCategory()
        {
            return _context.Categories.ToList();
        }

        public List<CategoryField> ShowCategoryFields(int id)
        {
            var advert = _context.Adverts.Find(id);

            int catId = 0;

            var category = _context.Categories.Find(advert.CategoryId);

            if (category.ParentId != null)
            {
                var subCategory = _context.Categories.Find(category.ParentId);

                if (subCategory.ParentId != null)
                {
                    var subsubCategory = _context.Categories.Find(subCategory.ParentId);

                    if (subsubCategory.ParentId != null)
                    {
                        catId = (int)subsubCategory.ParentId;
                    }
                    else
                    {
                        catId = (int)subCategory.ParentId;
                    }
                }
                else
                {
                    catId = (int)category.ParentId;
                }
            }
            else
            {
                catId = category.Id;
            }

            var categoryFields = _context.CategoryFields.Include(c => c.Field).Where(c => c.CategoryId == catId).ToList();

            return categoryFields;
        }

        public List<City> ShowCity(string name)
        {
            return _context.Cities.Where(c => c.Name.Contains(name)).OrderBy(c => c.Name).ToList();
        }

        public List<Gallery> ShowGallery(int id)
        {
            var gallery = _context.Galleries.Where(g => g.AdvertId == id).ToList();

            return gallery;
        }

        public List<Mark> ShowUserMark(int id)
        {
            var mark = _context.Marks.Include(m => m.Advert).Where(m => m.UserId == id).ToList();

            return mark;
        }

        public List<Visit> ShowUserVisits(int id)
        {
            var visit = _context.Visits.Include(v => v.Advert).Where(v => v.UserId == id).OrderByDescending(v => v.VisitDate).ToList();

            return visit;
        }

        public bool UpdateAdvert(string name, string des, bool isExpire, int id)
        {
            var ads = _context.Adverts.Find(id);

            ads.Name = name;
            ads.Des = des;
            ads.IsExpire = isExpire;

            _context.SaveChanges();

            return true;
        }

        public int UpdateVisit(int userid, int advertid, string date, string time)
        {
            var visit = _context.Visits.FirstOrDefault(v => v.UserId == userid && v.AdvertId == advertid);

            visit.VisitDate = date;
            visit.VisitTime = time;

            _context.SaveChanges();

            return visit.Id;
        }
    }
}
