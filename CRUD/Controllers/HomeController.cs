using CRUD.Models;
using LinqCrud.database;
using LinqCrud.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    
    [Authorize]
    // to restrict the user [Authorize(Users = "sprasains1")]

    public class HomeController : Controller
    {
        //dependency injection is better than instatiating everytime 
        ApplicationDbContext ctx = new ApplicationDbContext();
        IndexVM model = new IndexVM();
        
      
            public ActionResult Index()
        {
            //filling the viewmodel with the data 
          
            model.Players = ctx.Palyers.ToList();
            model.Teams = ctx.Teams.ToList();

           //model.Departments = ctx.Departments.Where(d=> (ctx.Palyers.FirstOrDefault(p=>p.DepartmentId==d.Id)).Salary>=200000).ToList();

            model.Departments = ctx.Departments.Where(d => d.Players.Any(p => p.Salary >= 200000)).ToList();
           
            return View(model);

        }
        [HttpPost]  //attributes
        public ActionResult Index(Team team)
        {
            ctx.Teams.Add(team);
            ctx.SaveChanges();

            model.Players = ctx.Palyers.ToList();
            model.Teams = ctx.Teams.ToList();
            model.Departments = ctx.Departments.Where(d => d.Players.Any(p => p.Salary >= 200000)).ToList();

            return View(model);
        
        }

        
        //in order to make thje ajax call
        //public JsonResult Index(int team)
        //{
        //    Team teamToremove = ctx.Teams.Find(id);

        //    ctx.Teams.Remove(teamToremove);
        //    ctx.SaveChanges();
        //    return Json(team, JsonRequestBehavior.AllowGet);
        //}


        public ActionResult DeleteTeam( int id)
        {
           Team teamToremove = ctx.Teams.Find(id);

           ctx.Teams.Remove(teamToremove);
           ctx.SaveChanges();
           return RedirectToAction("Index");
        }

        public ActionResult UpdateTeam(int id) 
        
        {
            Team teamToUpdate = ctx.Teams.Find(id);
             return View(teamToUpdate);
        }

        [HttpPost]
        public ActionResult UpdateTeam(int id , Team updatedTeam)
        {
            
            Team teamToUpdate = ctx.Teams.Find(id);
            teamToUpdate.Name = updatedTeam.Name;
            teamToUpdate.Location = updatedTeam.Location;
            teamToUpdate.HeadCoach = updatedTeam.HeadCoach;
            teamToUpdate.FoundingYear = updatedTeam.FoundingYear;
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}