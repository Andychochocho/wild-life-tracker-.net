using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WildLifeTracker.Models
{
    [Table("Species")]

    public class Specie
    {
        [Key]
        public int SpecieId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sighting> Sightings { get; set; }
    }
}
