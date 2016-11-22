<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/MasterPage/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="MCTuristic_Centro_Historico.GUI.Registro" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
            function Gurdar() {
                var actionData = " { 'nombre': '" + $("#<%=txtNombre.ClientID%>")[0].value   + "' , 'apellido': '" + $("#<%=txtApellidos.ClientID%>")[0].value + "' , 'email': '" + $("#<%=txtDireccionCorreo.ClientID%>")[0].value  + "' , 'contraseña': '" + $("#<%=txtContraseña.ClientID%>")[0].value + "' , 'numero': '" + $("#<%=txtTelefono.ClientID%>")[0].value + "'}  ";
            $.ajax({
                type: "POST",
                url: "Registro.aspx/Guardar",
                data: actionData,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: OnSuccess,
                failure: function (response) {
                    alert(response.d);
                }
            });
        }
        function OnSuccess(response) {
            alert("Respuesta " + response.d);
        }
    </script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Principal" runat="server">
<div class="wrapper inner">
<header id="header">
<div class="container">
                <div class="row">
                    <div class="col-lg-3 col-md-3">
                        <logo class="logo"><a href="PagPrincipal.aspx" ><img src="../Recursos/images/inner-logo.png" alt="Logo" title="Relax Spa Palace"/></a></logo>
                    </div>
                    <div class="col-lg-9 col-md-9">


                        <div class="home-menu">
                            <div class="navbar mm">
                                <div>
                                    <nav class="navbar navbar-default" role="navigation">

                                        <div class="navbar-header">
                                            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navbar-collapse-1"><span class="sr-only">Toggle navigation</span> <span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span></button>
                                        </div>
                                        <div id="navbar-collapse-1" class="collapse navbar-collapse pull-right">
                                            <ul class="nav navbar-nav">
                                                <li><a href="PagPrincipal.aspx">Inicio</a></li>
                                                <li class="dropdown">
                                                    <a href="#" data-toggle="dropdown" class="dropdown-toggle">Servicios<b class="caret"></b></a>
                                                    <ul class="dropdown-menu">
                                                        <li>

                                                            <div class="mm-content">
                                                                <div class="row">
                                                                    <ul class="col-sm-4 list-unstyled">
                                                                        <li>
                                                                            <p><strong>Empresa</strong></p>
                                                                        </li>
                                                                        <li><a href="QuieneSomo.aspx">Misión</a></li>
                                                                        <li><a href="QuieneSomo.aspx">Visión</a></li>
                                                                        <li><a href="QuieneSomo.aspx">Valores </a></li>
                                                                        <li><a href="QuieneSomo.aspx">¿Quiénes somos?</a></li>
                                                                    </ul>
                                                                    <%-- <ul class="col-sm-4 list-unstyled">
                                                                        <li>
                                                                            <p><strong>Section Title</strong></p>
                                                                        </li>
                                                                        <li><a href="#">Body Massage</a></li>
                                                                        <li><a href="#">Spa Treatments</a></li>
                                                                        <li><a href="#">Body Massage</a></li>
                                                                        <li><a href="#">Special Facial</a></li>
                                                                        <li><a href="#">Manicure</a></li>
                                                                        <li><a href="#">Pedicure</a></li>
                                                                    </ul>
                                                                    <ul class="col-sm-4 list-unstyled">
                                                                        <li>
                                                                            <p><strong>Section Title</strong></p>
                                                                        </li>
                                                                        <li><a href="#">Body Massage</a></li>
                                                                        <li><a href="#">Spa Treatments</a></li>
                                                                        <li><a href="#">Body Massage</a></li>
                                                                        <li><a href="#">Special Facial</a></li>
                                                                        <li><a href="#">Manicure</a></li>
                                                                        <li><a href="#">Pedicure</a></li>
                                                                    </ul>--%>
                                                                </div>
                                                            </div>
                                                        </li>
                                                    </ul>
                                                </li>


                                                <li class="dropdown">

                                                    <asp:HyperLink ID="HyperLink1" data-toggle="dropdown" class="dropdown-toggle" Visible="false" NavigateUrl="~/GUI/Principal.aspx" runat="server">Blog</asp:HyperLink>
                                                    <%--                                                    <a href="Principal.aspx"  data-toggle="dropdown" class="dropdown-toggle"> Blog<b class="caret"></b></a>--%>
                                                   -
                                                    <ul role="menu" class="dropdown-menu">
                                                        <li><a tabindex="-1" href="Principal.aspx">Página principal </a></li>
                                                        <li>
                                                            <asp:Button TabIndex="-1" ID="btnCerrarSecion" runat="server" Text=" Cerrar sesión" />
                                                        </li>
                                                    </ul>
                                                </li>


                                                <li class="dropdown">
                                                    <a href="Productos.aspx" data-toggle="dropdown" class="dropdown-toggle">Productos<b class="caret"></b></a>
                                                    <ul role="menu" class="dropdown-menu">
                                                        <li><a tabindex="-1" href="Productos.aspx">Lista Productos </a></li>
                                                        <%--      <li><a tabindex="-1" href="DetalleProducto.aspx"> Product Details</a></li>
                                                        <li><a tabindex="-1" href="cart.html"> Cart </a></li>
                                                        <li><a tabindex="-1" href="checkout.html"> Check Out</a></li>
                                                        <li><a tabindex="-1" href="register.html"> Login</a></li>
                                                        <li><a tabindex="-1" href="register.html"> Register</a></li>--%>
                                                    </ul>
                                                </li>


                                               <%-- <li class="dropdown">
                                                    <a href="#" data-toggle="dropdown" class="dropdown-toggle">Gallery<b class="caret"></b></a>
                                                    <ul role="menu" class="dropdown-menu">
                                                        <li><a tabindex="-1" href="galletry01.html">Double Column </a></li>
                                                        <li><a tabindex="-1" href="galletry02.html">Three Column</a></li>
                                                        <li><a tabindex="-1" href="galletry03.html">Four Column</a></li>
                                                        <li><a tabindex="-1" href="galletry04.html">Masonry Style</a></li>
                                                    </ul>
                                                </li>--%>


                                                <li>
                                                    <a href="Contactanos.aspx">Contactanos<b></b></a>
                                                </li>

                                            </ul>
                                        </div>
                                    </nav>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
</header>
<div class="gap"></div>
<section class="signup">
<div class="container">
<div class="row">
 
<div class="col-lg-9 col-md-9 col-sm-12 col-xs-12">
<div class="register">
<h2><font><font>Crea una cuenta</font></font></h2>
<form method="post" action="#">
<ul>
<li>
<label><font><font>Número de Teléfono *</font></font></label>
<asp:TextBox ID="txtTelefono" type="text" placeholder="Número teléfono" runat="server"></asp:TextBox>

</li>
</ul>
<ul class="row">
<li class="col-lg-6">
<label><font><font>Nombre *</font></font></label>
    <asp:TextBox ID="txtNombre" type="text" placeholder="Nombre" runat="server"></asp:TextBox>

</li>
<li class="col-lg-6">
<label><font><font>Apellido*</font></font></label>
    <asp:TextBox ID="txtApellidos" type="text" placeholder="Apellidos" runat="server"></asp:TextBox>

</li>
</ul>
<ul class="row">
<li class="col-lg-6">
<label><font><font>Dirección de correo electrónico*</font></font></label>
     <asp:TextBox ID="txtDireccionCorreo" type="text" placeholder="Dirección de correo electrónico" runat="server"></asp:TextBox>
</li>
<li class="col-lg-3">
<label><font><font>Contraseña *</font></font></label>
     <asp:TextBox ID="txtContraseña" type="text"  placeholder="******" runat="server"></asp:TextBox>

</li>
<li class="col-lg-3">
<label><font><font>Confirmar contraseña*</font></font></label>
 <asp:TextBox ID="txtConfirmarContraseña" type="text"  placeholder="******" runat="server"></asp:TextBox>
</li>
</ul>
<ul>
<li>
<label><font><font>Cruzamientos</font></font></label>
     <asp:TextBox ID="txtCruzamiento" type="text"  placeholder="Cruzamientos" runat="server"></asp:TextBox>

</li>
</ul>
 <ul class="row">
<li class="col-lg-6">
<label><font><font>Calle *</font></font></label>
 <asp:TextBox ID="txtCalle" type="text"  placeholder="Calle" runat="server"></asp:TextBox>
</li>
<li class="col-lg-6">
<label><font><font>Número*</font></font></label>
     <asp:TextBox ID="txtNumeroCalle" type="text"  placeholder="Número" runat="server"></asp:TextBox>
</li>
</ul>
<ul class="row">
<li class="col-lg-3">
<label><font><font>Descripción*</font></font></label>
 <asp:TextBox ID="txtDescripción" type="text"  placeholder="Descripción" runat="server"></asp:TextBox>
</li>
<li class="col-lg-3">
<label><font><font>Colonia*</font></font></label>
 <asp:TextBox ID="txtColonia" type="text"  placeholder="Colonia" runat="server"></asp:TextBox>
</li>
<li class="col-lg-3">
<label><font><font>Código postal*</font></font></label>
 <asp:TextBox ID="txtCodigoPostal" type="text"  placeholder="Código posta" runat="server"></asp:TextBox>
</li>
<li class="col-lg-3">
<label><font><font>Estado*</font></font></label>
     <asp:TextBox ID="txtEstado" type="text"  placeholder="Estado" runat="server"></asp:TextBox>
</li>
</ul>
<ul>
<li>
<font>
<font>
 <asp:Button ID="btnAgregar" class="btn btn-info boton1" runat="server" Text="Regístrace" OnClick="btnAgregar_Click"></asp:Button>
<%--<input id="Button1" type="button" class="btn btn-info boton1" onclick="Gurdar();" value="CREAR CUENTA" />--%>
</font>
</font>
</li>
</ul>
</div>
</div>
 
<div class="col-lg-3 col-md-3 col-sm-12 col-xs-12">
<div class="login">
<h2><font><font>Agregar Foto</font></font></h2>
<form method="post" action="#">
<ul>

<li>
<label><font><font><h3><i class="glyph-icon icon-image"></i>Foto*</h3></font></font></label>
   
                            <asp:Image ID="imgFoto" runat="server" Width="450" Height="300" alt="" />
                            <asp:FileUpload ID="fuFoto" runat="server" accept=" image/jpeg, image/png" />

    <asp:Button ID="btnVer" runat="server" Text="Visualizar imagen" CssClass="btn btn-purple" OnClick="btnVer_Click1" />
   <br />
     <%-- <script type="text/javascript">
          function showimagepreview(input) {

              if (input.files && input.files[0]) {
                  var reader = new FileReader();
                  reader.onload = function (e) {

                      $('#imagend').attr('src', e.target.result);
                      document.getElementsById("imagend")[0].setAttribute("src", e.target.result);
                  }
                  reader.readAsDataURL(input.files[0]);
              }
          }

             </script>--%>


        
</li>
    <li>
<label><font>Fecha de Nacimiento<font></font></font></label>
 <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="Calender" Format="dd-MM-yyyy" />
 <asp:TextBox ID="Calender" runat="server"></asp:TextBox>
</li>
         
                            
</ul>
</div>
</div>
 
</div>
</div>
</section>
</div>
    
<div class="gap"></div>

     
 
</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="scrip" runat="server">
</asp:Content>
