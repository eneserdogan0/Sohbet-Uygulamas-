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
        public Login()
        {
            InitializeComponent();
            //InitializeFirebase();
        }

        private async void GirisYBtn_Click(object sender, EventArgs e)
        {
            // Configure...
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyB4wf1T7rZ7-TXqFDt8I4bG4j7LH_7VtBk",
                AuthDomain = "sohbet-uygulamasi-enserdogan0.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
        // Add and configure individual providers
        new GoogleProvider().AddScopes("email"),
        new EmailProvider()
                    // ...
                },          
            };

            // ...and create your FirebaseAuthClient
            var client = new FirebaseAuthClient(config);
            var userCredential = await client.SignInWithEmailAndPasswordAsync("sedeneme12329@gmail.com", "deneme12");
            var user = userCredential.User;
            var uid = user.Uid;
            var name = user.Info.DisplayName; // more properties are available in user.Info
            var refreshToken = user.Credential.RefreshToken; // more properties are available in user.Credential

            label1.Text = "Hoş geldin  \n" + user.Info + "!UID\n: " + user.Uid;
        }
    }
}
