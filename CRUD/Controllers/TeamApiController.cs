using CRUD.Models;
using LinqCrud.database;
using LinqCrud.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD.Controllers
{
    public class TeamApiController : ApiController
    {
        //IHttpActionResult returns a status code so we changed all of the default return type to IHttpActionResult

        ApplicationDbContext ctx = new ApplicationDbContext();
        IndexVM model = new IndexVM();

        public IHttpActionResult Get()
        {
            try
            {
                model.Teams = ctx.Teams.ToList();
                return Ok(model);
            }
            catch (Exception ex)
            {
                throw;
                return InternalServerError(ex);

            }

        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)//this is supposed to return single item
        {
            Team singleTeam = ctx.Teams.Find(id);
            return Ok(singleTeam);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Team newTeam)
        {

            try
            {
                ctx.Teams.Add(newTeam);
                ctx.SaveChanges();
                return Created("/api/Team/" + newTeam.ID + "", newTeam);
            }

            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]Team updatedTeam)
        {
            try
            {
                Team teamToUpdate = ctx.Teams.Find(id);
                teamToUpdate.Name = updatedTeam.Name;
                teamToUpdate.Location = updatedTeam.Location;
                teamToUpdate.HeadCoach = updatedTeam.HeadCoach;
                teamToUpdate.FoundingYear = updatedTeam.FoundingYear;
                ctx.SaveChanges();
                return Ok(updatedTeam);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Team teamToremove = ctx.Teams.Find(id);
                ctx.Teams.Remove(teamToremove);
                ctx.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}