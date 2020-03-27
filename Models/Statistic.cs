using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BME77.Models
{
    public class Statistic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public int StatisticID { get; set; }
        public DateTime Time { get; set; }
        public string Page { get; set; }
        public string Route { get; set; }
      
    }
}
