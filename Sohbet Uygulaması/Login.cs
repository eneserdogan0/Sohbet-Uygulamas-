using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sohbet_Uygulaması
{
    public partial class Login : Form
    {
        private string AuthDomain;
        private string ApiKey;
        public Login(string AuthDomain, string ApiKey)
        {
            InitializeComponent();
            //InitializeFirebase();
            this.AuthDomain = AuthDomain;
            this.ApiKey = ApiKey;
        }

        private void GirisYBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AuthDomain, ApiKey);
            // Configure...
            //var config = new FirebaseAuthConfig
            //{
                
                     
            //};

            //label1.Text = "Hoş geldin  \n" + user.Info + "!UID\n: " + user.Uid;
        }

        private void KullaniciTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SifreTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
