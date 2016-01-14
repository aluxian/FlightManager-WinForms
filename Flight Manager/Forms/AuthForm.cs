using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Security.Cryptography;

namespace Flight_Manager {
    public partial class AuthForm : Form {
        private DatabaseContext db = new DatabaseContext();

        public AuthForm() {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            if (textBoxUsername.Text.Length == 0) {
                MessageBox.Show("Username cannot be empty.");
                return;
            }

            if (textBoxPassword.Text.Length == 0) {
                MessageBox.Show("Password cannot be empty.");
                return;
            }

            IEnumerable<User> query = from u in db.Users
                                      where u.Username == textBoxUsername.Text && u.Password == getHash(textBoxPassword.Text)
                                      select u;

            if (query.Count() == 0) {
                MessageBox.Show("User not found!");
            } else {
                Hide();
                new ManagerForm(query.First()).ShowDialog();
                Close();
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e) {
            if (textBoxUsername.Text.Length == 0) {
                MessageBox.Show("Please choose a username.");
                return;
            }

            if (textBoxPassword.Text.Length == 0) {
                MessageBox.Show("Please choose a password.");
                return;
            }

            var query = from u in db.Users
                        where u.Username == textBoxUsername.Text
                        select u;

            if (query.Count() > 0) {
                MessageBox.Show("That username is already taken.");
            } else {
                try {
                    User user = new User() {
                        Username = textBoxUsername.Text,
                        Password = getHash(textBoxPassword.Text)
                    };

                    db.Users.InsertOnSubmit(user);
                    db.SubmitChanges();

                    MessageBox.Show("Account created. You can now log in.");
                } catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private string getHash(string str) {
            return Encoding.Default.GetString(new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(str)));
        }
    }
}
