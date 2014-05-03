using LinqCrud.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class IndexVM
    {
       //property within class cannot be instatiated like this 
        //viewmodel is flexible 
    
        public Player Player { get; set; }
    //these are just the empty cells
        public Department Department { get; set; }
        public string playerName { get; set; } 
        
        
        public List<Player> Players { get; set; }
        public List<Department> Departments { get; set; }
        public List<Team> Teams { get; set; }


    }
}