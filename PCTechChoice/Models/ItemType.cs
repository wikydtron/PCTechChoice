using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCTechChoice.Models
{
    public class ItemType
    {
        public int ItemTypeID { get; set; }

        [StringLength(30)]
        [Required]
        public string TypeName { get; set; }

        public virtual ICollection<Component> Components { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }

    }
}
