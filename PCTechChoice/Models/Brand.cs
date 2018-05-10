using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PCTechChoice.Models
{
    public class Brand
    {
        public int BrandID { get; set; }//PK
        
        [StringLength(30)]
        [Required]
        public string BrandName { get; set; }

        //Nav Properties
        public virtual ICollection<Component> Components { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }

        
    }
}
