using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace CodeFirstProj.Models
{
    public class Location
    {
        [Key]
        public int Lid { get; set; }
        public string Lname { get; set; }
    }
}
