using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pruebaChuiSA
{
    public partial class voidTransaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVoidATransaction_Click(object sender, EventArgs e)
        {
            limpiarMensaje();           

            VoidTransactionRequest objVoidTransactionReq = new VoidTransactionRequest();
            objVoidTransactionReq.fullResponse = true;              

            VoidTransactionResponse objVoidTransactionRes = new VoidTransactionResponse();

            string url = "https://api-uat.kushkipagos.com/v1/charges/" + txtTicketNumber.Text;

            var json = new JavaScriptSerializer().Serialize(objVoidTransactionReq);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //Cuando es https
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            request.Method = "DELETE";
            request.Headers.Add("Private-Merchant-Id", util.llavePrivada);    
            request.Timeout = 18000000;

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try{
                var httpResponse = (HttpWebResponse)request.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    objVoidTransactionRes = new JavaScriptSerializer().Deserialize<VoidTransactionResponse>(result);

                    dvCorrecto.Visible = true;
                    lblCorrecto.Text = "ticketNumber --> " + objVoidTransactionRes.ticketNumber;                    
                }
            }catch (WebException ex){
                lblError.Text = "ticketNumber --> " + ex.Message;
                dvError.Visible = true;                              
            }
    
        }

        private void limpiarMensaje()
        {
            lblError.Text = "";
            dvError.Visible = false;
            lblCorrecto.Text = "";
            dvCorrecto.Visible = false;
            lblAdvertencia.Text = "";
            dvAdvertencia.Visible = false;
        }
    }
}