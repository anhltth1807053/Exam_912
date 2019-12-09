using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace exam_912.Models
{
    public class exam_912Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public exam_912Context() : base("name=exam_912Context")
        {
        }

        public System.Data.Entity.DbSet<exam_912.Models.Exam> Exams { get; set; }
    }
}
