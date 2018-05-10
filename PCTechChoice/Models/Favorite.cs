using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCTechChoice.Models
{
    public class Favorite
    {
        public int FavoriteID { get; set; }
        [StringLength(256)]
        [Required]
        public string Email { get; set; }
        [Required]
        public int ItemTypeID { get; set; }
        [Required]
        public int BrandID { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ItemType ItemType { get; set; }
    }
}
