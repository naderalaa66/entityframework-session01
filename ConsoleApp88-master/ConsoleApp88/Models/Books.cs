using Microsoft.Data.SqlClient.DataClassification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88.Models
{
    internal class Books
    {
        [Key]
       public string title { get; set; }
       public int ISBN { get; set; }
        public double price  { get; set; }
        public int pagegNumber { get; set; }
        public int years { get; set; }
        public int currentStock { get; set; }

    }
}
