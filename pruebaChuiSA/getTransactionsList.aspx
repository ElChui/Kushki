<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="getTransactionsList.aspx.cs" Inherits="pruebaChuiSA.getTransactionsList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> 

    <div class="container">
                                
        <%-- TITULO --%>
        <div class="row">                        
            <div class="col-sm-12 col-md12">      
                <h4 class="card-subtitle mb-2 text-primary">Get transactions list</h4> 
            </div>
        </div> 

                
      

         <div class="row">    
             <div class="col-sm-3 col-md3">  
                <div class="form-group">
                    <h5><b>Desde</b></h5>
                    <!-- Datepicker as text field -->
                    <div class="input-group date" data-date-format="yyyy-mm-dd">
                        <asp:TextBox ID="txtFechaDesde" runat="server" CssClass="form-control" placeholder="yyyy-mm-dd"></asp:TextBox>
                        <div class="input-group-addon">
                            <span class="glyphicon glyphicon-th"></span>
                        </div>
                    </div>
		        </div>
            </div>
                                 
            <div class="col-sm-3 col-md3">  
                <div class="form-group">
                    <h5><b>Hasta</b></h5>
                    <!-- Datepicker as text field -->
                    <div class="input-group date" data-date-format="yyyy-mm-dd">
                        <asp:TextBox ID="txtFechaHasta" runat="server" CssClass="form-control" placeholder="yyyy-mm-dd"></asp:TextBox>
                        <div class="input-group-addon">
                            <span class="glyphicon glyphicon-th"></span>
                        </div>
                    </div>
		        </div>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-3 col-md-3">
                <h6><b>&nbsp</b></h6>
                <asp:Button runat="server" Text="Get transactions list" ID="btnGetTransactionsList" CssClass="btn btn-info" OnClick="btnGetTransactionsList_Click"></asp:Button>
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

    <script language="javascript" type="text/javascript"> 
              
        $('.input-group.date').datepicker({ format: "yyyy-mm-dd" });

        $(document).ready(function () {
            Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);

            function EndRequestHandler(sender, args) {
                $('.input-group.date').datepicker({ dateFormat: 'yyyy-mm-dd' });
            }

        });
    </script>

</asp:Content>
