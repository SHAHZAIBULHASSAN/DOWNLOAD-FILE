using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOWNLOAD_FILE
{
    class Program
    {
        static void Main(string[] args)
        {
            string authType = "OAuth";
            string userName = "shahzaib@SHAHZAIBSAFDAR1.onmicrosoft.com";
            string password = "safdar786ALI!";
            string url = "https://org666f01ac.crm.dynamics.com";
            string appId = "51f81489-12ee-4a9e-aaae-a2591f45987d";
            string reDirectURI = "app://58145B91-0C36-4500-8554-080854F2AC97";
            string loginPrompt = "Auto";
            string ConnectionString = string.Format("AuthType = {0};Username = {1};Password = {2}; Url = {3}; AppId={4}; RedirectUri={5};LoginPrompt={6}", authType, userName, password, url, appId, reDirectURI, loginPrompt);



            CrmServiceClient svc = new CrmServiceClient(ConnectionString);

            if (svc.IsReady)
            {
                Console.WriteLine("CONNECTION IS OKAY");
                Console.WriteLine("Please ENTER FOLLOWING OPTIONS");
                Console.WriteLine("1-------------download file-----------");

                
                string a = Console.ReadLine();
                int aa = Convert.ToInt32(a);
                switch (aa)
                {

                    case 1:
                        Downlaod(svc);
                        break;

                }
            }
        }

        private static void Downlaod(CrmServiceClient svc)
        {
            
        }
    }
}
