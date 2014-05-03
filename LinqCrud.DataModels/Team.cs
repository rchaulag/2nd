using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCrud.DataModels
{
   public class Team
    {
       public int ID { get; set; }
       public string Name { get; set; }
       public string Location{ get; set; }
       public string HeadCoach { get; set; }
       public DateTime FoundingYear { get; set; }
       //(for reverse lookup like using where (d=>d.Players.Count -> 5)
       //we tried to avoid many-to-many forms as far as possible 
       public virtual List<Department> Departments { get; set;  }
    }
}


