using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace Flight_Manager {
    [Table(Name="Arrivals")]
    public class Arrival {
        [Column(CanBeNull = false, IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(CanBeNull = false)]
        public string Flight { get; set; }
        [Column(CanBeNull = false)]
        public string From { get; set; }
        [Column(CanBeNull = false)]
        public DateTime Time { get; set; }
        [Column(CanBeNull = false)]
        public string Status { get; set; }
    }
}
