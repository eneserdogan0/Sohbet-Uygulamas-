using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Sohbet_Uygulaması
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlDocument Config1 = new XmlDocument();
            Config1.Load("Config1.xml");
            
            string AuthDomain = Config1.DocumentElement.SelectSingleNode("/FireBaseAuthentication/AuthDomain").InnerText.Trim();
            string ApiKey = Config1.DocumentElement.SelectSingleNode("/FireBaseAuthentication/ApiKey").InnerText.Trim();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(AuthDomain, ApiKey));
        }
    }
}
