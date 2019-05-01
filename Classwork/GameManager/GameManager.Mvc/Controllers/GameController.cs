using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameManager.Sql;

namespace GameManager.Mvc.Controllers
{
    public class GameController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var connString = ConfigurationManager.ConnectionStrings["database"];
            var db = new SqlGameDatabase(connString.ConnectionString);
            var games = db.GetAll();
            //return Json(games, JsonRequestBehavior.AllowGet);
            return View(games);
        }

        private static SqlGameDatabase GetDatabase()
        {
            var connString = ConfigurationManager.ConnectionStrings["database"];
            var db = new SqlGameDatabase(connString.ConnectionString);
            return db;
        }

        public ActionResult Edit( int id )
        {
            var db = GetDatabase();
            var game = db.Get(id);
            if (game == null)
                return HttpNotFound();

            return View(game);
        }
        

        public ActionResult Create()
        {
            return View(new Game());
        }

        [HttpPost]
        public ActionResult Edit ( Game model )
        {
            var db = GetDatabase();
            var game = db.Update(model.Id, model);

            return RedirectToAction("Index");

        }
        
        [HttpPost]
        public ActionResult Delete(Game model)
        {

            var db = GetDatabase();
            db.Delete(model.Id);

            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var db = GetDatabase();
            var game = db.Get(id);

            if (game == null)
                return HttpNotFound();
            return View(game);
        }

        [HttpPost]
        public ActionResult Create( Game model )
        {

            var db = GetDatabase();
            db.Add(model);

            return RedirectToAction("Index");
        }

        

    }
}