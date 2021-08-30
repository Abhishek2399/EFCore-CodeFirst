using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations; // for key-attr.

namespace CodeFirstProj.Models
{
    /// <summary>
    /// This class represents one of the table in the database
    /// It should have properties for columns in the table 
    /// </summary>
    public class Employee 
    {
        /// <summary>
        /// To define a property as primary key we have Attribute [Key] present in the namespace  
        /// we are using models for tables and tables have primary key 
        /// </summary>
        [Key]
        public int Eid { get; set; }
        public string EName { get; set; }
        public int ESal { get; set; }


        
        public override string ToString()
        {
            string info = $"-------------\nID : {Eid}\nName : {EName}\nSalary : {ESal}\n-------------";
            return info;
        }


    }
}
