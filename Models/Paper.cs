using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BME77.Models
{
    public class Paper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public int ID { get; set; }
        public string Abstract { get; set; }
        [Display(Name = "Session")]
        public int SessionID { get; set; }
        [Display(Name = "Time Start")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM HH:mm}", ApplyFormatInEditMode = true)]
        public System.DateTime TimeStart { get; set; }
        [Display(Name = "Time End")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM HH:mm}", ApplyFormatInEditMode = true)]
        public System.DateTime TimeEnd { get; set; }
        public string Title { get; set; }   
        public virtual Session Session { get; set; }
        public string FullTextLink { get; set; }
        public string Author { get; set; }
    }
}
