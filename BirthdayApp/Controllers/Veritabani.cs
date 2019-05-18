using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.Controllers
{
    public static class Veritabani
    {
        private static Dictionary<string, DavetiyeModel> _liste;
        static Veritabani()
        {
            _liste = new Dictionary<string, DavetiyeModel>();

            _liste.Add("Ali", new DavetiyeModel
            {
                Ad = "Ali",
                Eposta = "ali@gmal.com",
                KatilmaDurumu = true
            });
            _liste.Add("Veli", new DavetiyeModel
            {
                Ad = "Veli",
                Eposta = "veli@gmal.com",
                KatilmaDurumu = false
            });
            _liste.Add("Berrin", new DavetiyeModel
            {
                Ad = "Berrin",
                Eposta = "berrin@gmal.com",
                KatilmaDurumu = true
            });
        }

        public static void Add(DavetiyeModel model)
        {
            string key = model.Ad.ToLower();
            if (_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key, model);
            }
        }
        public static IEnumerable<DavetiyeModel> Liste
        {
            get { return _liste.Values; }
        }
        
    }
}