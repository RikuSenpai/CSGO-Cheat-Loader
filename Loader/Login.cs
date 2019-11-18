using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinitySeal;

namespace Beta_Loader
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            SealCheck.HashChecks(); //Checks the integrity of the TrinitySeal and Newtonsoft DLL
            if (SealCheck.isValidDLL)
            {
                Seal.Secret = "program secret"; //Sets your program secret throughout the program
                Seal.Initialize("1.0"); //Carries out auto-update and grabs program variables
            }
        }

        private void OpenRegister_Click(object sender, EventArgs e)
        {
            SealCheck.HashChecks(); //Checks the integrity of the TrinitySeal and Newtonsoft DLL
            if (SealCheck.isValidDLL)
            {
                Register form = new Register(); //creates new form
                form.Show(); //show this form
            }
        }

        private void llogin_Click(object sender, EventArgs e)
        {
            SealCheck.HashChecks(); // Check integrity of auth files
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //bugs sometimes
            if (SealCheck.isValidDLL)
            {
                bool response = Seal.Login(Username.Text, Password.Text); //login using the first and the second textbox, there is a third argument that disables the trinity login messages
                if (response)
                {
                    /* Arguments in order: variable key, program token, username, password */
                    /* Username and password is required as the user must be logged in to retrieve variables */
                    Seal.GrabVariables("variables token", "program secret", Username.Text, Password.Text);

                    Main form = new Main(); //create a new main form
                    this.Hide(); //hide this form
                    form.Show(); //open the new main form
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //close the app if the form is closed
        }
    }
}
