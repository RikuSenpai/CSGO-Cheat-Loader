
using ManualMapInjection.Injection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinitySeal;

namespace Beta_Loader
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            SealCheck.HashChecks();
            
            if (SealCheck.isValidDLL)
            {
                if (!ProgramVariables.Freemode) // Checking that a login was actually required, that is quite useless cause if you use server sided vars u cant let the application be in free mode
                {
                    Security.ChallengeCheck(); //Checks if the user has logged in, passed the initialize method and hasn't triggered any security alarms
                    label2.Text = TrinitySeal.UserInfo.Username;
                    label4.Text = TrinitySeal.UserInfo.Expires.ToString();
                }
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //close the app if the form is closed
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            SealCheck.HashChecks();
            if (SealCheck.isValidDLL)
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //bugs sometimes

                WebClient mac = new WebClient(); //creates a new webclient
                mac.Proxy = null; //null its proxy so wireshark/fiddler will not see the link

                Process target = Process.GetProcessesByName("csgo").FirstOrDefault(); // csgo process check

                if (target != null) // check if csgo is open
                {
                    try //try to do a function
                    {
                        mac.Headers.Add("User-Agent", TrinitySeal.Seal.Var("user_agent")); //add headers using a sv side var(trinity)
                        byte[] crypted = mac.DownloadData(TrinitySeal.Seal.Var("download")); //download the dll using a sv side var and saving it to bytes
                        byte[] decrypted = AES.DecryptAES(crypted, Encoding.UTF8.GetBytes(TrinitySeal.Seal.Var("crypt_pass"))); // decrypt the dll using a pass lol
                        var injector = new ManualMapInjector(target) { AsyncInjection = true }; //initializing the injector
                        Inject.Text = $"hmodule = 0x{injector.Inject(decrypted).ToInt64():x8}"; //inject dll
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception happened : " + ex); //check some exceptions
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Please open CSGO"); //error open csgo
                }
            }
        }
    }
}
