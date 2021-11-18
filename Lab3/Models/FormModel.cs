using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class FormModel
    {
        public string Name { get; set; }

        
       [Range(1,5)]
        public int Repeats { get; set; }
    }
}
