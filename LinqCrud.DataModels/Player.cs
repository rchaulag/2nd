using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCrud.DataModels
{
   public class Player
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public int Number { get; set; }
        public double Salary { get; set; }
   
       //Foreign Key here because every plaer has only one department

       public int DepartmentId {get; set;}


   }
}
