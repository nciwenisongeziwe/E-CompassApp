using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using EcompassServiceProxy;
//using localhost

namespace theWebTest
{
    public partial class Home : System.Web.UI.Page
    {
        //private static readonly EndpointAddress Endpoint = new EndpointAddress("http://localhost:50874/EcompassService.svc");
        //public EcompassServiceClient _client { get; set; }
        private localhost.EcompassService _client;



        protected void Page_Load(object sender, EventArgs e)
        {
            //InitializeEcompassServiceClient();

        }

        protected void btnLoadDB_Click(object sender, EventArgs e)
        {
            CheckConnectionAsync();
        }

        private async Task CheckConnectionAsync()
        {
            _client = new localhost.EcompassService();
            try
            {
                //str = _client.SayHelloTo();
                lblText.Text = _client.SayHelloTo();
                //await CheckDBConnTask(); /// after this step it jumps out of method

            }
            catch (Exception ex)
            {
                lblText.Text = ex.Message;
                //Console.WriteLine(ex.Message);
            }
        }

        //private Task<string> CheckDBConnTask()
        //{
        //    //return _client.SayHelloToAsync();
        //}

        void InitializeEcompassServiceClient()
        {
            BasicHttpBinding binding = CreateBasicHttpBinding();
            ////_client = new EcompassServiceClient(binding, Endpoint);
        }


        static BasicHttpBinding CreateBasicHttpBinding()
        {
            BasicHttpBinding binding = new BasicHttpBinding
            {
                Name = "basicHttpBinding",
                MaxBufferSize = 2147483647,
                MaxReceivedMessageSize = 2147483647
            };

            TimeSpan timeout = new TimeSpan(0, 0, 30);
            binding.SendTimeout = timeout;
            binding.OpenTimeout = timeout;
            binding.ReceiveTimeout = timeout;
            return binding;
        }

    }
}