using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;

namespace MvcStok.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var degerler = db.TblKategoriler.ToList();
            return View(degerler);
        }
        [HttpGet] //Sayfa ilk yükleneceği zaman bunu kullanırız.
        public ActionResult YeniKategori()
        {
            return View();
        }


        [HttpPost] /*Bunu yazmamızın nedeni biz butona basınca kaydetme işlemi olsun. Bunu yazmazsaak her sayfayı yeniledikçe null değer döner.*/
        public ActionResult YeniKategori(TblKategoriler p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniKategori");
            }

            db.TblKategoriler.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult SİL (int id)
        {
            var kategori = db.TblKategoriler.Find(id);
            db.TblKategoriler.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }

        public ActionResult KategoriGetir(int id)
        {
            var ktgr = db.TblKategoriler.Find(id);
            return View("KategoriGetir", ktgr);
        }
        public ActionResult Guncelle(TblKategoriler p1)
        {
            var ktgr = db.TblKategoriler.Find(p1.KategoriId);
            ktgr.KategoriAd = p1.KategoriAd;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}