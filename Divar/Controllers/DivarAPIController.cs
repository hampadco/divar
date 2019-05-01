using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Divar.DataAccessLayer.Entities;
using Divar.DataAccessLayer.Context;
using Divar.Core.Classes;

[Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class DivarAPIController : ControllerBase
    {
        DivarContext _context;

        public DivarAPIController(DivarContext context)
        {
            _context = context;
        }

        public List<City> GetCities()
        {
            return _context.Cities.OrderBy(c => c.Name).ToList();
        }

    public List<Product> GetProduct()
    {
        return _context.Products.OrderBy(c => c.Id).ToList();
    }
    public List<Advert> GetAdvertsByCityId(int id)
    {
        return _context.Adverts.Where(a => a.IsExpire == false && a.CityId == id).OrderByDescending(a => a.Date).ToList();
    }


    public List<Gallery> GetAdvertsGalleries(int id)
    {
        return _context.Galleries.Where(g => g.AdvertId == id).ToList();
    }

    public string GetUserMobileNumber(int id)
    {
        return _context.Users.FirstOrDefault(u => u.Id == id).Mobile.ToString();
    }

    public string GetUserID(string id, string password)
    {
        var user = _context.Users.FirstOrDefault(u => u.Mobile == id && u.Password == HashGenerators.EncodingPassWithMD5(password));

        if (user != null)
        {
            return user.Id.ToString();
        }
        else
        {
            return "0";
        }
    }
}
