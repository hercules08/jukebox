using Awesomium.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JukeBox.Tests
{
    [TestClass]
    public class Payment_TEST
    {
        [TestMethod]
        public void LIVE_Can_Charge_Through_Square()
        {
            string applicationId = "sq0idp-GAJG6CGWZ8_RGvpt_a8gLA";
            string accessToken = "sq0atp-B1TOBtpMTsp3DI60qyVdBA";
            string locationId = "8JBEZBHY1HM4K";

            // Get card nonce;
            GetCardNonce(applicationId);
            // Send the payment request


        }

        [TestMethod]
        public void SANDBOX_Can_Charge_Through_Square()
        {
            string applicationId = "sandbox-sq0idp-GAJG6CGWZ8_RGvpt_a8gLA";
            string accessToken = "sandbox-sq0atb-HS3WN-Tl31jkwNd5IfLFOQ";
            string locationId = "CBASEBsfwySf3csXbi2K_lLCZ1wgAQ";

            GetCardNonce(applicationId);
        }

        public string GetCardNonce(string applicationId)
        {
            bool doneLoading = false;
            string nonce = string.Empty;
            WebSession session = WebCore.CreateWebSession(@"C:\SessionDataPath", WebPreferences.Default);
            WebView view = WebCore.CreateWebView(0, 0, session);
            view.Source = "http://localhost:54775/Home/PaySquare".ToUri();

            //string html = string.Empty;

            //using (StreamReader sr = new StreamReader("HTML.html"))
            //{
            //    html = sr.ReadToEnd();
            //}

            ////html = @"<html><head><script>function heyNow() { return { name:'Damola',number:1 }; }</script></head><body><b>Hello, World!</b><i>Hello, World!</i><i>Hello, World!</i></body></html>";
            ////view.LoadHTML(@"<html><head><script>function heyNow() { return { name:'Damola',number:1 }; }</script></head><body><b>Hello, World!</b><i>Hello, World!</i><i>Hello, World!</i></body></html>");
            //view.LoadHTML(html);
            

            int count = 0;

            view.LoadingFrameComplete += (sender, e) =>
            {
                //doneLoading = true;
                var result = view.ExecuteJavascriptWithResult("document.documentElement.outerHTML");
                Debug.WriteLine(result);
                //var result = view.ExecuteJavascriptWithResult("heyNow()");
                //string json = result.ToString();
                //JSObject returned = (JSObject)result;
                //string value = returned["name"];
                //string aResult = JsonConvert.SerializeObject(returned);
                //NameNumberModel model = JsonConvert.DeserializeObject<NameNumberModel>(aResult);

                //Debug.WriteLine("Awesominum Loaded with name"+value);

                if (count == 5)
                {
                    var abcde = view.ExecuteJavascriptWithResult("document.documentElement.outerHTML");
                    doneLoading = true;
                }
                count++;
            };


            while (!doneLoading)
            {
                Thread.Sleep(100);
                WebCore.Update();
            }
            return nonce;
        }

        public class NameNumberModel
        {
            public string Name { get; set; }
            public int Number { get; set; }
        }
    }
}
