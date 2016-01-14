using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flight_Manager.Forms {
    public partial class ArrivalEditorForm : Form {
        private DatabaseContext db = new DatabaseContext();
        private Arrival initialArrival;

        public ArrivalEditorForm() {
            InitializeComponent();
        }

        public ArrivalEditorForm(Arrival arrival) {
            InitializeComponent();
            initialArrival = arrival;
            buttonAdd.Text = "Save Arrival";
            this.Text = "Edit";

            textBoxFlight.Text = arrival.Flight;
            textBoxFrom.Text = arrival.From;
            dateTimePicker.Value = arrival.Time;
            textBoxStatus.Text = arrival.Status;
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            if (textBoxFlight.Text.Length == 0) {
                MessageBox.Show("Please enter a flight name.");
                return;
            }

            if (textBoxFrom.Text.Length == 0) {
                MessageBox.Show("Please enter where the flight comes from.");
                return;
            }

            if (textBoxStatus.Text.Length == 0) {
                MessageBox.Show("Please enter the status of the flight.");
                return;
            }

            if (initialArrival != null) {
                db.Arrivals.DeleteOnSubmit(db.Arrivals.Single(a => a.Id == initialArrival.Id));
            }

            db.Arrivals.InsertOnSubmit(new Arrival() {
                Flight = textBoxFlight.Text,
                From = textBoxFrom.Text,
                Time = dateTimePicker.Value,
                Status = textBoxStatus.Text
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
