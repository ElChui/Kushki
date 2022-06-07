<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="pago.aspx.cs" Inherits="pruebaChuiSA.pago" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> 

    <div class="container">
                                
        <%-- TITULO --%>
        <div class="row">                        
            <div class="col-sm-12 col-md12">      
                <h4 class="card-subtitle mb-2 text-primary">Make a charge</h4> 
            </div>
        </div> 
        
        <div class="row"> 
            <div class="col-sm-10 col-md-10">
                <h6><b>Json request</b></h6>
            </div>
        </div>
        <div class="row">            
            <div class="col-sm-10 col-md-10">
                <p>
                    {"token":"562515ba7cda4decb49dd7bd67a9f620",
                    "amount":{"subtotalIva":0,"subtotalIva0":70.88,"ice":0,"iva":0,"currency":"USD"},
                    "metadata":{"Referencia":"987654"},"contactDetails":
                    {"documentType":"CC","documentNumber":"0105038079","email":"frankchui@hotmail.com","firstName":"Franklin",
                    "lastName":"Chuisaca","phoneNumber":"+593996929966"},
                    "orderDetails":{"siteDomain":"example.com",
                    "shippingDetails":{"name":"Franklin Chuisaca","phone":"+593996929966","address1":"Ricaurte - La unión",
                    "address2":"Junto al Sudamericano","city":"Cuenca","region":"Azuay","country":"Ecuador"},
                    "billingDetails":{"name":"Franklin Chuisaca","phone":"+593996929966","address1":"Ricaurte - La unión",
                    "address2":"Junto al Sudamericano","city":"Cuenca","region":"Azuay","country":"Ecuador"}},
                    "productDetails":{"product":[{"id":"10000005","title":"parlantes","price":65.25,"sku":"10101042",
                    "quantity":1},{"id":"10000006","title":"laptop","price":15,"sku":"004834GQ","quantity":1}]},"fullResponse":true}
                </p>
            </div>                       
        </div>
        
        <div class="row">
            <div class="col-sm-3 col-md-3">
                <h6><b>&nbsp</b></h6>
                <asp:Button runat="server" Text="Make a Charge" ID="btnMakeACharge" CssClass="btn btn-info" OnClick="btnMakeACharge_Click"></asp:Button>
            </div>
        </div>

        <br />

        <%-- MENSAJE --%>
        <div class="row">
            <div class="col-sm-11 col-md-11">
                <div id="dvError" runat="server" visible="false" class="alert alert-danger">
                    <strong>Error! </strong>
                    <asp:Label ID="lblError" runat="server" />
                </div>
                <div id="dvCorrecto" runat="server" visible="false" class="alert alert-success">
                    <strong>Correcto! </strong>
                    <asp:Label ID="lblCorrecto" runat="server" />
                </div>
                <div id="dvAdvertencia" runat="server" visible="false" class="alert alert-warning">
                    <strong>Advertencia! </strong>
                    <asp:Label ID="lblAdvertencia" runat="server" />
                </div>                        
            </div>
        </div>

        <div class="row"> 
            <div class="col-sm-10 col-md-10">
                <h6><b>Response</b></h6>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>ticketNumber: <small id="ticketNumber" runat="server">ticketNumber</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>transactionReference: <small id="transactionReference" runat="server">transactionReference</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>token: <small id="token" runat="server">token</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>processorId: <small id="processorId" runat="server">processorId</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>fullResponse: <small id="fullResponse" runat="server">fullResponse</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>transactionId: <small id="transactionId" runat="server">transactionId</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>recap: <small id="recap" runat="server">recap</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>responseText: <small id="responseText" runat="server">responseText</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>acquirerBank: <small id="acquirerBank" runat="server">acquirerBank</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>cardHolderName: <small id="cardHolderName" runat="server">cardHolderName</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>ip: <small id="ip" runat="server">ip</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>lastFourDigits: <small id="lastFourDigits" runat="server">lastFourDigits</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>maskedCardNumber: <small id="maskedCardNumber" runat="server">maskedCardNumber</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>binCard: <small id="binCard" runat="server">binCard</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>approvedTransactionAmount: <small id="approvedTransactionAmount" runat="server">approvedTransactionAmount</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>paymentBrand: <small id="paymentBrand" runat="server">paymentBrand</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>subtotalIva: <small id="subtotalIva" runat="server">subtotalIva</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>iceValue: <small id="iceValue" runat="server">iceValue</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>subtotalIva0: <small id="subtotalIva0" runat="server">subtotalIva0</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>requestAmount: <small id="requestAmount" runat="server">requestAmount</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>created: <small id="created" runat="server">created</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>ivaValue: <small id="ivaValue" runat="server">ivaValue</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>responseCode: <small id="responseCode" runat="server">responseCode</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>merchantName: <small id="merchantName" runat="server">merchantName</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>transactionType: <small id="transactionType" runat="server">transactionType</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>processorName: <small id="processorName" runat="server">processorName</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>approvalCode: <small id="approvalCode" runat="server">approvalCode</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>processorBankName: <small id="processorBankName" runat="server">processorBankName</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>transactionStatus: <small id="transactionStatus" runat="server">transactionStatus</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>transactionReference: <small id="transactionReference1" runat="server">transactionReference</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>syncMode: <small id="syncMode" runat="server">syncMode</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>binInfo: <small id="binInfo" runat="server">binInfo</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>currencyCode: <small id="currencyCode" runat="server">currencyCode</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>cardCountry: <small id="cardCountry" runat="server">cardCountry</small></h5>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-5 col-md-5">
                <h5>merchantId: <small id="merchantId" runat="server">merchantId</small></h5>
            </div>
            <div class="col-sm-5 col-md-5">
                <h5>rules: <small id="rules" runat="server">rules</small></h5>
            </div>
        </div>
    </div>

</asp:Content>