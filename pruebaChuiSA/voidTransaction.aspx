<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="voidTransaction.aspx.cs" Inherits="pruebaChuiSA.voidTransaction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> 

    <div class="container">
                                
        <%-- TITULO --%>
        <div class="row">                        
            <div class="col-sm-12 col-md12">      
                <h4 class="card-subtitle mb-2 text-primary">Void a transaction</h4> 
            </div>
        </div> 

        <div class="row"> 
            <div class="col-sm-2 col-md-2">
                <h6>ticketNumber</h6>
            </div>
            <div class="col-sm-6 col-md-6">                
                <asp:TextBox ID="txtTicketNumber" Text="" runat="server" CssClass="form-control" required="true"></asp:TextBox>
            </div>                
        </div>

        <div class="row">
            <div class="col-sm-3 col-md-3">
                <h6><b>&nbsp</b></h6>
                <asp:Button runat="server" Text="Void a transaction" ID="btnVoidATransaction" CssClass="btn btn-info" OnClick="btnVoidATransaction_Click"></asp:Button>
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

</asp:Content>