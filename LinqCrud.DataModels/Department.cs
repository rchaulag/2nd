using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCrud.DataModels
{
     public class Department
    {
         public int Id { get; set; }
         public string Name { get; set; }
         public string TeamCoach { get; set; }

  
         public virtual List<Player> Players { get; set; }//these work just like other properties if we use them, but if we dun use them then they won't exist
           

         //Fk
         public int TeamId { get; set; }



     }
}
