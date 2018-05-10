using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCTechChoice.Models
{
    public class Component
    {
        public int BrandID { get; set; }
        public int ItemTypeID { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ItemType Type { get; set; }


    }
}
