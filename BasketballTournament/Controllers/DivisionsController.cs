using BasketballTournament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace BasketballTournament.Controllers
{
    public class DivisionsController : Controller
    {
        private ApplicationDbContext _context;

        public DivisionsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Divisions
        public ActionResult Index()
        {
            var divisions = _context.Divisions.Include(m => m.DivisionType).ToList();
            var viewModel = _context.DivisionTypes.ToList();

            return View(divisions);
        }

        public ActionResult Create()
        {
            var divisiontype = _context.DivisionTypes.ToList();

            var viewModel = new DivisionViewModel
            {
                DivisionTypes = divisiontype
            };

            return View("Create", viewModel);
        }

        [HttpPost]
        public ActionResult Create(Division division)
        {
            
            var divisions = _context.Divisions.SingleOrDefault(m => m.Id == division.Id);

            divisions.Name = division.Name;
            divisions.DivisionType = division.DivisionType;
            divisions.TimeSlots = division.TimeSlots;


            _context.Divisions.Add(division);
            _context.SaveChanges();

            return RedirectToAction("Index", "Divisions");
        }

        public ActionResult Edit(int id)
        {
            var divisions = _context.Divisions.SingleOrDefault(m => m.Id == id);

            var viewModel = new DivisionViewModel
            {
                Division = divisions,
                DivisionTypes = _context.DivisionTypes.ToList()
            };
            return View("Edit", viewModel);
        }

        [HttpPost]
        public ActionResult Edit(Division division)
        {
            var divisions = _context.Divisions.Include(m => m.DivisionType).SingleOrDefault(m => m.Id == division.Id);
            divisions.Name = division.Name;
            divisions.DivisionType = division.DivisionType;
            divisions.TimeSlots = division.TimeSlots;
            
            _context.SaveChanges();

            return RedirectToAction("Index", "Divisions");
        }
        
        public ActionResult Details(int id)
        {
            var divisions = _context.Divisions.Include(m => m.DivisionType).SingleOrDefault(m => m.Id == id);
            
            return View(divisions);
                
        }

        public ActionResult Delete(int id)
        {
            var divisions = _context.Divisions.SingleOrDefault(m => m.Id == id);

            _context.Divisions.Remove(divisions);
            _context.SaveChanges();

            return RedirectToAction("Index", "Divisions");
        }
    }
}