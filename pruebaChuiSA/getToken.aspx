<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="getToken.aspx.cs" Inherits="pruebaChuiSA.getToken" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> 

    <div class="container">
                                
        <%-- TITULO --%>
        <div class="row">                        
            <div class="col-sm-12 col-md12">      
                <h4 class="card-subtitle mb-2 text-primary">Request a card token</h4> 
            </div>
        </div> 

        <div class="row"> 
            <div class="col-sm-2 col-md-2">
                <h6>name</h6>
            </div>
            <div class="col-sm-6 col-md-6">                
                <asp:TextBox ID="txtName" Text="Franklin Chuisaca" runat="server" CssClass="form-control" required="true"></asp:TextBox>
            </div>                
        </div>
        <div class="row"> 
            <div class="col-sm-2 col-md-2">
                <h6>number</h6>
            </div>
            <div class="col-sm-6 col-md-6">                
                <asp:TextBox ID="txtNumber" Text="5451951574925480" runat="server" CssClass="form-control" required="true" maxlength="16" onkeypress="return validaNumericos(event)"></asp:TextBox>
            </div>                
        </div>
        <div class="row"> 
            <div class="col-sm-2 col-md-2">
                <h6>expiryMonth</h6>
            </div>
            <div class="col-sm-6 col-md-6">                
                <asp:TextBox ID="txtExpiryMonth" Text="08" runat="server" CssClass="form-control" required="true" maxlength="2" onkeypress="return validaNumericos(event)"></asp:TextBox>
            </div>                
        </div>
        <div class="row"> 
            <div class="col-sm-2 col-md-2">
                <h6>expiryYear</h6>
            </div>
            <div class="col-sm-6 col-md-6">                
                <asp:TextBox ID="txtExpiryYear" Text="23" runat="server" CssClass="form-control" required="true" maxlength="2" onkeypress="return validaNumericos(event)"></asp:TextBox>
            </div>                
        </div>
        <div class="row"> 
            <div class="col-sm-2 col-md-2">
                <h6>cvv</h6>
            </div>
            <div class="col-sm-6 col-md-6">                
                <asp:TextBox ID="txtCvv" Text="121" TextMode="Password" runat="server" CssClass="form-control" required="true" maxlength="4" onkeypress="return validaNumericos(event)"></asp:TextBox>
            </div>                
        </div>       
        <div class="row">
            <div class="col-sm-3 col-md-3">
                <h6><b>&nbsp</b></h6>                
                <asp:Button runat="server" Text="Get Token" ID="btnGetToken" CssClass="btn btn-info" OnClick="btnGetToken_Click"></asp:Button>
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

    </div>

    <script type="text/javascript">

        function validaNumericos(event) {
            if (event.charCode >= 48 && event.charCode <= 57) {
                return true;
            }
            return false;
        }

    </script>

</asp:Content>