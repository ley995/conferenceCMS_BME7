using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BME77.Models
{
    public class Session
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Session()
        {
            this.Papers = new HashSet<Paper>();
        }

        public int ID { get; set; }
        [Display(Name = "Session ID")]
        public string ID_C { get; set; }
        public string Name { get; set; }
        public string Room { get; set; }
        public string Chair { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paper> Papers { get; set; }
        [Display(Name = "Start")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM HH:mm}", ApplyFormatInEditMode = true)]
        public System.DateTime TimeStart { get; set; }
        [Display(Name = "End")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM HH:mm}", ApplyFormatInEditMode = true)]
        public System.DateTime TimeEnd { get; set; }
        public bool IsWorkshop { get; set; }
        public bool IsOral { get; set; }
        public bool IsKeyLab { get; set; }
        public bool IsBreak { get; set; }
    }
    
}
