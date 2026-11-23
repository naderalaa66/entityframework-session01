using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88.Models
{
    internal class Category
    {
        [Key]
        public string Name { get; set; }
        public string discription { get; set; }

        public string theconditionactiveorNonactive  { get; set; }
    }
}
