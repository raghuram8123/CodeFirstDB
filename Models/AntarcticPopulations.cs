using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstDB.Models
{
    
    [Table(name:"antarctic_populations",Schema ="bird")]
    public class AntarcticPopulations
    {
        [Key]
        public int species_id { get; set; }

        public string locality { get; set; }

        public int population_count { get; set; }

        public DateTime date_of_count { get; set; }
    }
}