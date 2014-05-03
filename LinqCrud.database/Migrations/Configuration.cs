namespace LinqCrud.database.Migrations
{
    using LinqCrud.DataModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LinqCrud.database.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LinqCrud.database.ApplicationDbContext context)
        {
            context.Teams.AddOrUpdate(
              t => t.ID,
              new Team { ID= 1, Name="Packers", Location="Green Bay, WI", FoundingYear= new DateTime(1926,1,1),HeadCoach="Mike McCarthy" },
              new Team { ID= 2, Name="Packers", Location="Green Bay, WI", FoundingYear= new DateTime(1926,1,1),HeadCoach="Mike McCarthy" },
                  new Team { ID= 3, Name="Packers", Location="Green Bay, WI", FoundingYear= new DateTime(1926,1,1),HeadCoach="Mike McCarthy" },
                      new Team { ID= 4, Name="Packers", Location="Green Bay, WI", FoundingYear= new DateTime(1926,1,1),HeadCoach="Mike McCarthy" },
                          new Team { ID= 5, Name="Packers", Location="Green Bay, WI", FoundingYear= new DateTime(1926,1,1),HeadCoach="Mike McCarthy" },
                              new Team { ID= 6, Name="Packers", Location="Green Bay, WI", FoundingYear= new DateTime(1926,1,1),HeadCoach="Mike McCarthy" },
                                  new Team { ID= 7, Name="Packers", Location="Green Bay, WI", FoundingYear= new DateTime(1926,1,1),HeadCoach="Mike McCarthy" }
                                     

            );

            context.Departments.AddOrUpdate(
              t => t.Id,
              new Department {Id = 1, Name = "Offense", TeamCoach="Good man", TeamId=1},
              new Department {Id = 2, Name = "Defense", TeamCoach="WartsorttaMan", TeamId=1},
                  new Department {Id = 3, Name = "Special", TeamCoach="RealMan", TeamId=1},
                  new Department {Id = 4, Name = "Offense", TeamCoach="Good man", TeamId=2},
                  new Department {Id = 5, Name = "Defense", TeamCoach="MainMam", TeamId=2},
                  new Department {Id = 6, Name = "Offense", TeamCoach="Good man", TeamId=3},
                  new Department {Id = 7, Name = "Special", TeamCoach="Good man", TeamId=3}
            );


            context.Palyers.AddOrUpdate(
              t => t.Id,
              new Player { Id =1, Name="Aaron Rogers", Number =32, Salary= 2000000.00, DepartmentId=1},
               new Player { Id =2, Name="Sambo Twain  ", Number =32, Salary= 3000000.00, DepartmentId=2},
               new Player { Id =3, Name="Michael Jhonson", Number =32, Salary= 4000000.00, DepartmentId=3},
               new Player { Id =4, Name="Andrew Adams", Number =32, Salary= 5000000.00, DepartmentId=2},
               new Player { Id =5, Name="Samuel Adams", Number =32, Salary= 2000000.00, DepartmentId=1},
               new Player { Id =6, Name="Aaron Rogers", Number =32, Salary= 7000000.00, DepartmentId=3},
               new Player { Id =7, Name="Bobby Jackson", Number =32, Salary= 8000000.00, DepartmentId=3},
               new Player { Id =8, Name="Rambo Sambo", Number =32, Salary= 9000000.00, DepartmentId=2}
            );


        }
    }
}
