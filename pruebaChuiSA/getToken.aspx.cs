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
    public partial class getToken : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {

        }      

        protected void btnGetToken_Click(object sender, EventArgs e)
        {
            limpiarMensaje();

            string[] resultado = util.obtenerToken(txtName.Text, txtNumber.Text, txtExpiryMonth.Text, txtExpiryYear.Text, txtCvv.Text, 16.98, "USD");

            if (resultado[0] == "0"){
                dvCorrecto.Visible = true;
                lblCorrecto.Text = "Token --> " + resultado[1];
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