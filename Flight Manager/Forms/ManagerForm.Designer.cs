namespace Flight_Manager {
    partial class ManagerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arrivalsList = new System.Windows.Forms.ListView();
            this.Flight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.departuresList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Destination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteDeparture = new System.Windows.Forms.Button();
            this.buttonDeleteArrival = new System.Windows.Forms.Button();
            this.buttonEditDeparture = new System.Windows.Forms.Button();
            this.buttonEditArrival = new System.Windows.Forms.Button();
            this.buttonAddDeparture = new System.Windows.Forms.Button();
            this.buttonAddArrival = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUsername.Location = new System.Drawing.Point(6, 24);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(53, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "John Doe";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(165, 19);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.arrivalsList);
            this.groupBox1.Location = new System.Drawing.Point(266, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 214);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arrivals";
            // 
            // arrivalsList
            // 
            this.arrivalsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Flight,
            this.From,
            this.Time,
            this.Status});
            this.arrivalsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrivalsList.FullRowSelect = true;
            this.arrivalsList.GridLines = true;
            this.arrivalsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.arrivalsList.Location = new System.Drawing.Point(3, 16);
            this.arrivalsList.MultiSelect = false;
            this.arrivalsList.Name = "arrivalsList";
            this.arrivalsList.Size = new System.Drawing.Size(474, 195);
            this.arrivalsList.TabIndex = 3;
            this.arrivalsList.UseCompatibleStateImageBehavior = false;
            this.arrivalsList.View = System.Windows.Forms.View.Details;
            // 
            // Flight
            // 
            this.Flight.Text = "Flight";
            this.Flight.Width = 70;
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 220;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.departuresList);
            this.groupBox2.Location = new System.Drawing.Point(266, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 214);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Departures";
            // 
            // departuresList
            // 
            this.departuresList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Destination,
            this.columnHeader2,
            this.columnHeader3,
            this.Gate});
            this.departuresList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departuresList.FullRowSelect = true;
            this.departuresList.GridLines = true;
            this.departuresList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.departuresList.Location = new System.Drawing.Point(3, 16);
            this.departuresList.MultiSelect = false;
            this.departuresList.Name = "departuresList";
            this.departuresList.Size = new System.Drawing.Size(474, 195);
            this.departuresList.TabIndex = 1;
            this.departuresList.UseCompatibleStateImageBehavior = false;
            this.departuresList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Flight";
            this.columnHeader1.Width = 70;
            // 
            // Destination
            // 
            this.Destination.Text = "Destination";
            this.Destination.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 120;
            // 
            // Gate
            // 
            this.Gate.Text = "Gate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelUsername);
            this.groupBox3.Controls.Add(this.buttonLogout);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 49);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(12, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 265);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stats";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonDeleteDeparture);
            this.groupBox5.Controls.Add(this.buttonDeleteArrival);
            this.groupBox5.Controls.Add(this.buttonEditDeparture);
            this.groupBox5.Controls.Add(this.buttonEditArrival);
            this.groupBox5.Controls.Add(this.buttonAddDeparture);
            this.groupBox5.Controls.Add(this.buttonAddArrival);
            this.groupBox5.Location = new System.Drawing.Point(12, 67);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(246, 108);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Edit";
            // 
            // buttonDeleteDeparture
            // 
            this.buttonDeleteDeparture.Location = new System.Drawing.Point(125, 77);
            this.buttonDeleteDeparture.Name = "buttonDeleteDeparture";
            this.buttonDeleteDeparture.Size = new System.Drawing.Size(115, 23);
            this.buttonDeleteDeparture.TabIndex = 5;
            this.buttonDeleteDeparture.Text = "Delete Departure";
            this.buttonDeleteDeparture.UseVisualStyleBackColor = true;
            this.buttonDeleteDeparture.Click += new System.EventHandler(this.buttonDeleteDeparture_Click);
            // 
            // buttonDeleteArrival
            // 
            this.buttonDeleteArrival.Location = new System.Drawing.Point(6, 77);
            this.buttonDeleteArrival.Name = "buttonDeleteArrival";
            this.buttonDeleteArrival.Size = new System.Drawing.Size(115, 23);
            this.buttonDeleteArrival.TabIndex = 4;
            this.buttonDeleteArrival.Text = "Delete Arrival";
            this.buttonDeleteArrival.UseVisualStyleBackColor = true;
            this.buttonDeleteArrival.Click += new System.EventHandler(this.buttonDeleteArrival_Click);
            // 
            // buttonEditDeparture
            // 
            this.buttonEditDeparture.Location = new System.Drawing.Point(125, 48);
            this.buttonEditDeparture.Name = "buttonEditDeparture";
            this.buttonEditDeparture.Size = new System.Drawing.Size(115, 23);
            this.buttonEditDeparture.TabIndex = 3;
            this.buttonEditDeparture.Text = "Edit Departure";
            this.buttonEditDeparture.UseVisualStyleBackColor = true;
            this.buttonEditDeparture.Click += new System.EventHandler(this.buttonEditDeparture_Click);
            // 
            // buttonEditArrival
            // 
            this.buttonEditArrival.Location = new System.Drawing.Point(6, 48);
            this.buttonEditArrival.Name = "buttonEditArrival";
            this.buttonEditArrival.Size = new System.Drawing.Size(115, 23);
            this.buttonEditArrival.TabIndex = 2;
            this.buttonEditArrival.Text = "Edit Arrival";
            this.buttonEditArrival.UseVisualStyleBackColor = true;
            this.buttonEditArrival.Click += new System.EventHandler(this.buttonEditArrival_Click);
            // 
            // buttonAddDeparture
            // 
            this.buttonAddDeparture.Location = new System.Drawing.Point(125, 19);
            this.buttonAddDeparture.Name = "buttonAddDeparture";
            this.buttonAddDeparture.Size = new System.Drawing.Size(115, 23);
            this.buttonAddDeparture.TabIndex = 1;
            this.buttonAddDeparture.Text = "Add Departure";
            this.buttonAddDeparture.UseVisualStyleBackColor = true;
            this.buttonAddDeparture.Click += new System.EventHandler(this.buttonAddDeparture_Click);
            // 
            // buttonAddArrival
            // 
            this.buttonAddArrival.Location = new System.Drawing.Point(6, 19);
            this.buttonAddArrival.Name = "buttonAddArrival";
            this.buttonAddArrival.Size = new System.Drawing.Size(115, 23);
            this.buttonAddArrival.TabIndex = 0;
            this.buttonAddArrival.Text = "Add Arrival";
            this.buttonAddArrival.UseVisualStyleBackColor = true;
            this.buttonAddArrival.Click += new System.EventHandler(this.buttonAddArrival_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 458);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManagerForm";
            this.Text = "Flight Manager";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView arrivalsList;
        private System.Windows.Forms.ColumnHeader Flight;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView departuresList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Destination;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader Gate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonEditDeparture;
        private System.Windows.Forms.Button buttonEditArrival;
        private System.Windows.Forms.Button buttonAddDeparture;
        private System.Windows.Forms.Button buttonAddArrival;
        private System.Windows.Forms.Button buttonDeleteDeparture;
        private System.Windows.Forms.Button buttonDeleteArrival;
        private System.Windows.Forms.Timer timer;
    }
}