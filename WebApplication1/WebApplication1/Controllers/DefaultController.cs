using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using WebApplication1.Dto;
using WebApplication1.Models;
using WebApplication1.ToApi;

namespace WebApplication1.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpPost]
        public KullaniciDto getTest([FromBody]LoginInfoParameter loginInfoParameter)
        {
            if (loginInfoParameter.Tc== "12312312312" && loginInfoParameter.Tel== "5426781991")
            {
                KullaniciDto _kisi = new KullaniciDto() { Ad = "Furkan", Soyad = "Yağlı", Tc = "12312312312", Tel = "5426781991", Mail = "uygarakinalan@gmail.com" };
                return _kisi;

            }
            else
            {
                KullaniciDto _kisi = new KullaniciDto() { Ad = "hatalı", Soyad = "Yağlı", Tc = "12312312312", Tel = "5426781991", Mail = "uygarakinalan@gmail.com" };
                return _kisi;
            }
        }



    }
}
