using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace Flight_Manager {
    [Database]
    public partial class DatabaseContext : DataContext {
        public Table<User> Users;
        public Table<Arrival> Arrivals;
        public Table<Departure> Departures;
        public DatabaseContext() : base(Properties.Settings.Default.DatabaseConn) { }
    }
}
