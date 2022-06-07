using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace pruebaChuiSA
{
    public class util
    {

        public static string llavePublica = "8f89909cda97475781e535217f891523"; //Chui
        public static string llavePrivada = "4f5f638630c648728ba6390766cf11d1"; //Chui

        public static string[] obtenerToken(string name, string number, string expiryMonth, string expiryYear, string cvv, double totalAmount, string currency)
        {

            string[] token = new string[2];
            token[0] = "0";
            token[1] = "";

            card objTarjeta = new card();
            
            if (name == "") {
                objTarjeta.name = "Franklin Chuisaca";
                objTarjeta.number = "5451951574925480";
                objTarjeta.expiryMonth = "08";
                objTarjeta.expiryYear = "23";
                objTarjeta.cvv = "121";
            }else{
                objTarjeta.name = name;
                objTarjeta.number = number;
                objTarjeta.expiryMonth = expiryMonth;
                objTarjeta.expiryYear = expiryYear;
                objTarjeta.cvv = cvv;
            }
            
            TokenRequest objTokenReq = new TokenRequest();
            objTokenReq.card = objTarjeta;
            objTokenReq.totalAmount = totalAmount;
            objTokenReq.currency = currency;
            
            TokenResponse objTokenRes = new TokenResponse();

            string url = "https://api-uat.kushkipagos.com/card/v1/tokens";

            var json = new JavaScriptSerializer().Serialize(objTokenReq);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //Cuando es https
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            request.Method = "POST";
            request.Headers.Add("Public-Merchant-Id", llavePublica);    
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
                    objTokenRes = new JavaScriptSerializer().Deserialize<TokenResponse>(result);

                    token[1] = objTokenRes.token;
                }
             }catch (WebException ex){
                 token[0] = "1";
                 token[1] = ex.Message;                             
             }

            return token;
        }

    }
}