﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpBase.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="ProyectoWeb.GUI.Principal" %>
<asp:Content ID="Content3" ContentPlaceHolderID="cphTituloPagina" runat="server">
    Inicio
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphSesion" runat="server">
    <asp:PlaceHolder ID="phSesion" runat="server" Visible="true">
        <a href="#" title="My Account" class="user-profile clearfix" data-toggle="dropdown">
            <asp:Image ID="imgUsuario" runat="server" Width="28" ImageUrl="../Recursos/agileui.com/demo/monarch/assets/image-resources/gravatar.jpg" />
            <asp:Label ID="lblUsuario" runat="server" role="span" Text="André Salazar"></asp:Label>
            <i class="glyph-icon icon-angle-down"></i>
        </a>

        <div class="dropdown-menu float-left">
            <div class="box-sm">
                <div class="login-box clearfix">
                    <div class="user-img">
                        <asp:LinkButton ID="lbtnCambiarFoto" CssClass="change-img" runat="server">Cambiar foto</asp:LinkButton>
                        <asp:Image ID="imgMiniaturaUsuario" runat="server" ImageUrl="../Recursos/agileui.com/demo/monarch/assets/image-resources/gravatar.jpg" />
                    </div>
                    <div class="user-info">
                        <span>
                            <asp:Label ID="lblNombreUsuario" runat="server" Text="André Salazar"></asp:Label>
                        </span>
                        <br />
                        <asp:LinkButton ID="lbtnEditarPerfil" runat="server">Editar perfil</asp:LinkButton>
                        <asp:LinkButton ID="lbtnVerNotificaciones" runat="server">Ver notificaciones</asp:LinkButton>
                    </div>
                </div>
                <%--<div class="divider"></div>
                                <ul class="reset-ul mrg5B">
                                    <li>
                                        <a href="#">
                                            <i class="glyph-icon float-right icon-caret-right"></i>
                                            View account details
                                
                                        </a>
                                    </li>
                                </ul>--%>
                <div class="pad5A button-pane button-pane-alt text-center">
                    <asp:LinkButton ID="lbtnSesion" runat="server" CssClass="btn display-block font-normal btn-danger">
                                        <i class="glyph-icon icon-power-off"></i>
                                        Cerrar sesión
                    </asp:LinkButton>
                </div>
            </div>
        </div>
    </asp:PlaceHolder>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
        <div class="row">
            <div class="col-lg-12">
                <div class="panel">
                    <div class="panel-body">
                        <center>
                        <h1 class="text-primary"><b>Bienvenido a M.C. Turistic</b></h1>
                            <img src="../Recursos/agileui.com/demo/monarch/logo.png" />
                        </center>
                    </div>
                </div>
            </div>
            <div class="col-lg-12">
                <div class="panel">
                    <div class="panel-heading">
                        <center>
                        <h2 class="text-primary"><i class="glyph-icon icon-building"></i> <b>Descripción de la página</b></h2>
                            </center>
                    </div>
                    <div class="panel-body">
                        <div aling="justify">
                            <h3>
                                Esta es la página administrativa de M.C. Turistic, cualquier cambio realizado será reflejado en todos los registros de la base de datos.
                                <br />
                                <br />
                                Hemos trabajado en todo el diseño y funcionabilidad del sitio para un rendimiento óptimo. Se recomienda verificar las secciones a las que se ingresa,
                                para evitar algún tipo de problema al ingresar datos y evitar más trabajo para el personal técnico.
                                <br />
                                <br />
                            </h3>
                        </div>
                        <center>
                            <h4>
                            Gracias por su preferencia.
                            <br /><br />
                            Disfrute su día. <i class="glyph-icon icon-smile-o"></i>
                                </h4>
                            
                        </center>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
