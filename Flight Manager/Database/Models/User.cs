using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace Flight_Manager {
    [Table(Name="Users")]
    public class User {
        [Column(CanBeNull = false, IsPrimaryKey = true)]
        public string Username { get; set; }
        [Column(CanBeNull = false)]
        public string Password { get; set; }
    }
}
