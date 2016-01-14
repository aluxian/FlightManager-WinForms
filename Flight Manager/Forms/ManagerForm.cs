using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Flight_Manager.Forms;

namespace Flight_Manager {
    public partial class ManagerForm : Form {
        private DatabaseContext db = new DatabaseContext();

        public ManagerForm(User user) {
            InitializeComponent();
            labelUsername.Text = user.Username;
        }

        private void buttonLogout_Click(object sender, EventArgs e) {
            Hide();
            new AuthForm().ShowDialog();
            Close();
        }

        private void ManagerForm_Load(object sender, EventArgs e) {
            loadArrivals();
            loadDepartures();
        }

        private void loadArrivals() {
            arrivalsList.Items.Clear();

            foreach (Arrival arrival in db.Arrivals.OrderBy(a => a.Time).Take(10)) {
                ListViewItem item = new ListViewItem(new string[] {
                    arrival.Flight, 
                    arrival.From, 
                    arrival.Time.ToShortTimeString(),
                    arrival.Status 
                });

                item.Tag = arrival;
                arrivalsList.Items.Add(item);
            }
        }

        private void loadDepartures() {
            departuresList.Items.Clear();

            foreach (Departure departure in db.Departures.OrderBy(d => d.Time).Take(10)) {
                ListViewItem item = new ListViewItem(new string[] {
                    departure.Flight, 
                    departure.Destination, 
                    departure.Time.ToShortTimeString(),
                    departure.Status,
                    departure.Gate.ToString()
                });

                item.Tag = departure;
                departuresList.Items.Add(item);
            }
        }

        private void buttonAddArrival_Click(object sender, EventArgs e) {
            if (new ArrivalEditorForm().ShowDialog() == DialogResult.OK) {
                loadArrivals();
            }
        }

        private void buttonAddDeparture_Click(object sender, EventArgs e) {
            if (new DepartureEditorForm().ShowDialog() == DialogResult.OK) {
                loadDepartures();
            }
        }

        private void buttonEditArrival_Click(object sender, EventArgs e) {
            if (arrivalsList.SelectedItems.Count == 0) {
                MessageBox.Show("Select an item from the arrivals list.");
            } else if (new ArrivalEditorForm((Arrival)arrivalsList.SelectedItems[0].Tag).ShowDialog() == DialogResult.OK) {
                loadArrivals();
            }
        }

        private void buttonEditDeparture_Click(object sender, EventArgs e) {
            if (departuresList.SelectedItems.Count == 0) {
                MessageBox.Show("Select an item from the departures list.");
            } else if (new DepartureEditorForm((Departure)departuresList.SelectedItems[0].Tag).ShowDialog() == DialogResult.OK) {
                loadDepartures();
            }
        }

        private void buttonDeleteArrival_Click(object sender, EventArgs e) {
            if (arrivalsList.SelectedItems.Count == 0) {
                MessageBox.Show("Select an item from the arrivals list.");
            } else {
                db.Arrivals.DeleteOnSubmit((Arrival)arrivalsList.SelectedItems[0].Tag);

                try {
                    db.SubmitChanges();
                    loadArrivals();
                } catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonDeleteDeparture_Click(object sender, EventArgs e) {
            if (departuresList.SelectedItems.Count == 0) {
                MessageBox.Show("Select an item from the departures list.");
            } else {
                db.Departures.DeleteOnSubmit((Departure)departuresList.SelectedItems[0].Tag);

                try {
                    db.SubmitChanges();
                    loadDepartures();
                } catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e) {
            loadArrivals();
            loadDepartures();
        }
    }
}
