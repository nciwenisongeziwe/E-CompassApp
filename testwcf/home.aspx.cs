using System;

namespace testwcf
{
    public partial class home : System.Web.UI.Page
    {
  //      private localhost.EcompassService _client;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHala_Click(object sender, EventArgs e)
        {
            BuildStr();
        }

        private void BuildStr()
        {
//            _client = new localhost.EcompassService();
            //str = ecompassService.SayHelloTo();

            //InitializeEcompassServiceClient();
            try
            {
               // lblMessage.Text = _client.SayHelloToAsync();
                //str = await _client.SayHelloToAsync(); /// after this step it jumps out of method
                //Products = await _client.Products.;
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
                //Console.WriteLine(ex.Message);
            }

        }

    }
}