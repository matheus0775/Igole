using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;

namespace Igole.Model
{
    public class ModCardapio
    {
        [PrimaryKey, AutoIncrement]
        public int? Id { get; set; } 
        public String _id { get; set; }
        public String nameProduct { get; set; }
        public String description { get; set; }
        public String image { get; set; }
        public String Real { get; set; } //????
        public String price { get; set; }
        public String stock { get; set; }
        public Object volumeType  { get; set; }
        public String amountVolume { get; set; }
        public Object category { get; set; }
        public Object subCategory {get; set;}
        public Object tag { get; set; }

  
    }

}
