using BasketballTournament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace BasketballTournament.Controllers

{
    public class BasketballsController : Controller
    {
        private ApplicationDbContext _context;

        public BasketballsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Basketballs
        public ActionResult Index()
        {
            var teams = _context.Teams.ToList();

            return View(teams);
        }

        //GET: Basketballs/Create
        public ActionResult Create()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Create(Team team)
        {


            _context.Teams.Add(team);
            _context.SaveChanges();


            return RedirectToAction("Index", "Basketballs");
        }

        public ActionResult Edit(int id)
        {
            var teams = _context.Teams.SingleOrDefault(x => x.Id == id);

            return View(teams);
        }

        [HttpPost]
        public ActionResult Edit(Team team)
        {
            var teams = _context.Teams.SingleOrDefault(x => x.Id == team.Id);

            teams.TeamName = team.TeamName;
            teams.PhoneNumber = team.PhoneNumber;
            teams.Email = team.Email;

            _context.SaveChanges();

            return RedirectToAction("Index", "Basketballs");
        }

        public ActionResult Details(int id)
        {
            var teams = _context.Teams.SingleOrDefault(x => x.Id == id);

            return View(teams);
        }

        public ActionResult Delete(int id)
        {
            var teams = _context.Teams.SingleOrDefault(x => x.Id == id);            

            _context.Teams.Remove(teams);
            _context.SaveChanges();

            return RedirectToAction("Index", "Basketballs");
        }
    }
}