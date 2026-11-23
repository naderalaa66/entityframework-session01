using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88.Models
{
    internal class authors
    {
        [Key]
        public string fristName { get; set; }
        public string Lastname { get; set; }

        public string emailaddress { get; set; }
        public string shortbiograohy { get; set; }

        public DataType birth { get; set; }





    }
}
