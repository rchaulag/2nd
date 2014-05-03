using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCrud.DataModels
{
    public class ApplicationUser : IdentityUser
    {

        //Make two class libraries with extensions database and datamodel.
        //Add reference to the main project(startup project) of .datamodel and .database class
        //database class should refer to database class library
        //copy and paste the connection string from web config and paste them into app config
        //delete attach.mdf file propertiy 
        //manage nuget libraries to all of the class libraries We created earlier 

    }
}
