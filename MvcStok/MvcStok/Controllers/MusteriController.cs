using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;

namespace MvcStok.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var degerler = db.TblMusteriler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMusteri(TblMusteriler p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniMusteri");
            }

            db.TblMusteriler.Add(p1);
            db.SaveChanges();
            return View();

        }
        //Silme işilemi için;
        public ActionResult SİL(int id)
        {
         var musteri= db.TblMusteriler.Find(id);
            db.TblMusteriler.Remove(musteri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriGetir(int id)
        {
            var mstr = db.TblMusteriler.Find(id);
            return View("MusteriGetir", mstr);
        }
     public ActionResult Guncelle(TblMusteriler p1)
        {
            var mstr = db.TblMusteriler.Find(p1.MusteriId);
            mstr.MusteriAd = p1.MusteriAd;
            mstr.MusteriSoyad = p1.MusteriSoyad;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}