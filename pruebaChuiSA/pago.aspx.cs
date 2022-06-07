using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace pruebaChuiSA
{
    public partial class pago : System.Web.UI.Page
    {      

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }        

        protected void btnMakeACharge_Click(object sender, EventArgs e)
        {
            limpiarMensaje();

            double totalAmount = 70.88;
            string currency = "USD";

            string[] resultado = util.obtenerToken("", "", "", "", "", totalAmount, currency);          

            if (resultado[0] == "0"){

                amount objAmount = new amount();
                objAmount.subtotalIva = 0;
                objAmount.subtotalIva0 = totalAmount;
                objAmount.ice = 0;
                objAmount.iva = 0;
                objAmount.currency = currency;

                metadata objMetadata = new metadata();
                objMetadata.Referencia = "987654";

                contactDetails objContactDetails = new contactDetails();
                objContactDetails.documentType = "CC";
                objContactDetails.documentNumber = "0105038079";
                objContactDetails.email = "frankchui@hotmail.com";
                objContactDetails.firstName = "Franklin";
                objContactDetails.lastName = "Chuisaca";
                objContactDetails.phoneNumber = "+593996929966";

                shippingDetails objShippingDetails = new shippingDetails();
                objShippingDetails.name = "Franklin Chuisaca";
                objShippingDetails.phone = "+593996929966";
                objShippingDetails.address1 = "Ricaurte - La unión";
                objShippingDetails.address2 = "Junto al Sudamericano";
                objShippingDetails.city = "Cuenca";
                objShippingDetails.region = "Azuay";
                objShippingDetails.country = "Ecuador";

                billingDetails objBillingDetails = new billingDetails();
                objBillingDetails.name = "Franklin Chuisaca";
                objBillingDetails.phone = "+593996929966";
                objBillingDetails.address1 = "Ricaurte - La unión";
                objBillingDetails.address2 = "Junto al Sudamericano";
                objBillingDetails.city = "Cuenca";
                objBillingDetails.region = "Azuay";
                objBillingDetails.country = "Ecuador";

                orderDetails objOrderDetails = new orderDetails();
                objOrderDetails.siteDomain = "example.com";
                objOrderDetails.shippingDetails = objShippingDetails;
                objOrderDetails.billingDetails = objBillingDetails;

                product objProduct1 = new product();
                objProduct1.id = "10000005";
                objProduct1.title = "parlantes";
                objProduct1.price = 65.25;
                objProduct1.sku = "10101042";
                objProduct1.quantity = 1;

                product objProduct2 = new product();
                objProduct2.id = "10000006";
                objProduct2.title = "laptop";
                objProduct2.price = 15.00;
                objProduct2.sku = "004834GQ";
                objProduct2.quantity = 1;

                product[] objArrayProduct = new product[2];
                objArrayProduct[0] = objProduct1;
                objArrayProduct[1] = objProduct2;

                productDetails objProductDetails = new productDetails();
                objProductDetails.product = objArrayProduct;

                MakeACargeRequest objMakeACargeRequest = new MakeACargeRequest();

                objMakeACargeRequest.token = resultado[1];
                objMakeACargeRequest.amount = objAmount;
                objMakeACargeRequest.metadata = objMetadata;
                objMakeACargeRequest.contactDetails = objContactDetails;
                objMakeACargeRequest.orderDetails = objOrderDetails;
                objMakeACargeRequest.productDetails = objProductDetails;
                objMakeACargeRequest.fullResponse = true;

                MakeACargeResponse objMakeACargeRes = new MakeACargeResponse();

                string url = "https://api-uat.kushkipagos.com/card/v1/charges";

                var json = new JavaScriptSerializer().Serialize(objMakeACargeRequest);

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //Cuando es https
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/json";
                request.Method = "POST";
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
                        objMakeACargeRes = new JavaScriptSerializer().Deserialize<MakeACargeResponse>(result);

                        ticketNumber.InnerText = objMakeACargeRes.ticketNumber;
                        transactionReference.InnerText = objMakeACargeRes.transactionReference;

                        token.InnerText = objMakeACargeRes.details.token;
                        fullResponse.InnerText = objMakeACargeRes.details.fullResponse.ToString();
                        recap.InnerText = objMakeACargeRes.details.recap;
                        acquirerBank.InnerText = objMakeACargeRes.details.acquirerBank;
                        ip.InnerText = objMakeACargeRes.details.ip;
                        maskedCardNumber.InnerText = objMakeACargeRes.details.maskedCardNumber;
                        approvedTransactionAmount.InnerText = objMakeACargeRes.details.approvedTransactionAmount.ToString();
                        subtotalIva.InnerText = objMakeACargeRes.details.subtotalIva.ToString();
                        subtotalIva0.InnerText = objMakeACargeRes.details.subtotalIva0.ToString();
                        created.InnerText = objMakeACargeRes.details.created.ToString();
                        responseCode.InnerText = objMakeACargeRes.details.responseCode;
                        transactionType.InnerText = objMakeACargeRes.details.transactionType;
                        approvalCode.InnerText = objMakeACargeRes.details.approvalCode;
                        transactionStatus.InnerText = objMakeACargeRes.details.transactionStatus;
                        syncMode.InnerText = objMakeACargeRes.details.syncMode;
                        currencyCode.InnerText = objMakeACargeRes.details.currencyCode;
                        merchantId.InnerText = objMakeACargeRes.details.merchantId;
                        processorId.InnerText = objMakeACargeRes.details.processorId;
                        transactionId.InnerText = objMakeACargeRes.details.transactionId;
                        responseText.InnerText = objMakeACargeRes.details.responseText;
                        cardHolderName.InnerText = objMakeACargeRes.details.cardHolderName;
                        lastFourDigits.InnerText = objMakeACargeRes.details.lastFourDigits;
                        binCard.InnerText = objMakeACargeRes.details.binCard;
                        paymentBrand.InnerText = objMakeACargeRes.details.paymentBrand;
                        iceValue.InnerText = objMakeACargeRes.details.iceValue.ToString();
                        requestAmount.InnerText = objMakeACargeRes.details.requestAmount.ToString();
                        ivaValue.InnerText = objMakeACargeRes.details.ivaValue.ToString();
                        merchantId.InnerText = objMakeACargeRes.details.merchantId;
                        processorName.InnerText = objMakeACargeRes.details.processorName;
                        processorBankName.InnerText = objMakeACargeRes.details.processorBankName;
                        transactionReference.InnerText = objMakeACargeRes.details.transactionReference;
                        binInfo.InnerText = objMakeACargeRes.details.binInfo.ToString();
                        cardCountry.InnerText = objMakeACargeRes.details.cardCountry;
                        rules.InnerText = objMakeACargeRes.details.rules.ToString();

                        dvCorrecto.Visible = true;
                        lblCorrecto.Text = "ticketNumber --> " + objMakeACargeRes.ticketNumber;                        
                    }
                 }catch (WebException ex){
                     lblError.Text = ex.Message;
                     dvError.Visible = true;            
                 }

            }else{
                lblError.Text = "Token --> " + resultado[1];
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