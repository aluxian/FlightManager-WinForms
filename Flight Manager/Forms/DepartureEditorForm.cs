using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flight_Manager.Forms {
    public partial class DepartureEditorForm : Form {
        private DatabaseContext db = new DatabaseContext();
        private Departure initialDeparture;

        public DepartureEditorForm() {
            InitializeComponent();
        }

        public DepartureEditorForm(Departure departure) {
            InitializeComponent();
            initialDeparture = departure;
            buttonAdd.Text = "Save Departure";
            this.Text = "Edit";

            textBoxFlight.Text = departure.Flight;
            textBoxDestination.Text = departure.Destination;
            dateTimePicker.Value = departure.Time;
            textBoxStatus.Text = departure.Status;
            numericUpDownGate.Value = departure.Gate;
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            if (textBoxFlight.Text.Length == 0) {
                MessageBox.Show("Please enter a flight name.");
                return;
            }

            if (textBoxDestination.Text.Length == 0) {
                MessageBox.Show("Please enter the destination.");
                return;
            }

            if (textBoxStatus.Text.Length == 0) {
                MessageBox.Show("Please enter the status of the flight.");
                return;
            }

            if (initialDeparture != null) {
                db.Departures.DeleteOnSubmit(db.Departures.Single(d => d.Id == initialDeparture.Id));
            }

            db.Departures.InsertOnSubmit(new Departure() {
                Flight = textBoxFlight.Text,
                Destination = textBoxDestination.Text,
                Time = dateTimePicker.Value,
                Status = textBoxStatus.Text,
                Gate = Convert.ToInt32(numericUpDownGate.Value)
            });

            try {
                db.SubmitChanges();
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
