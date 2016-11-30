<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpBase.Master" AutoEventWireup="true" CodeBehind="GestionEstablecimientos.aspx.cs" Inherits="MCTuristic_Centro_Historico.GUI.GestionEstablecimientos" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content3" ContentPlaceHolderID="cphTituloPagina" runat="server">
    Gestion de establecimientos
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

                    <h3 class="text-center font-bold"><i class="glyph-icon icon-building"></i>Control de establecimientos </h3>
                    <div class="divider"></div>
                    <asp:LinkButton ID="lbtnNuevo" runat="server" CssClass="btn btn-blue-alt"><i class="glyph-icon icon-plus-circle"></i> Nuevo</asp:LinkButton>
                    <div class="divider"></div>
                    <div class="col-lg-6">
                        <div class="form-group border-blue">

                            <asp:TextBox ID="txtIdEstablecimiento" runat="server" Visible="false"></asp:TextBox>
                            <h3><i class="glyph-icon icon-tag"></i>Nombre</h3>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control border-blue"></asp:TextBox>
                            <br />
                            <h3><i class="glyph-icon icon-phone"></i>Teléfono</h3>
                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control border-blue"></asp:TextBox>
                            <br />
                            <h3><i class="glyph-icon icon-facebook-square"></i>Facebook</h3>
                            <asp:TextBox ID="txtFacebook" runat="server" CssClass="form-control border-blue"></asp:TextBox>
                            <br />
                            <h3><i class="glyph-icon icon-sign-in"></i>Hora de apertura</h3>
                            <asp:TextBox ID="txtAbrir" runat="server" CssClass="form-control border-blue"></asp:TextBox>
                            <br />
                            <h3><i class="glyph-icon icon-sign-out"></i>Hora de cierre</h3>
                            <asp:TextBox ID="txtCerrar" runat="server" CssClass="form-control border-blue"></asp:TextBox>
                            <br />
                            <h3><i class="glyph-icon icon-cutlery"></i><b>Servicios</b></h3>
                            <asp:Button ID="btnServicios" runat="server" Text="Ver servicios" CssClass="btn btn-primary" OnClick="btnServicios_Click" />
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group border-blue">
                            <h3><i class="glyph-icon icon-image"></i>Foto</h3>
                            <center>
                                <asp:Image ID="imgEstablecimiento" runat="server"></asp:Image>
                            </center>
                            <br />
                            <asp:FileUpload ID="fuFoto" CssClass="btn-primary" runat="server" Visible="true" />
                            <asp:Button ID="btnSubir" runat="server" CssClass="btn btn-primary" Text="Subir foto" OnClick="btnSubir_Click" />
                        </div>
                    </div>
                    <div class="col-lg-12 form-group">
                        <div class="col-lg-12 form-group">
                            <asp:TextBox ID="txtLatitud" runat="server" Visible="false"></asp:TextBox>
                            <asp:TextBox ID="txtLongitud" runat="server" Visible="false"></asp:TextBox>

                            <h3><i class="glyph-icon icon-file-text"></i>Ubicación</h3>
                            <div class="example-box-wrapper">
                                <div id="map-basic" style="height: 300px;"></div>
                            </div>
                        </div>
                        <div class="col-lg-12">
                            <div class="divider"></div>

                            <asp:LinkButton ID="lbtnGuardar" runat="server" CssClass="btn btn-blue-alt" OnClick="lbtnGuardar_Click"><i class="glyph-icon icon-save"></i> Guardar</asp:LinkButton>
                            <asp:LinkButton ID="lbtnModificar" runat="server" CssClass="btn btn-blue-alt"><i class="glyph-icon icon-edit"></i> Modificar</asp:LinkButton>
                            <asp:LinkButton ID="lbtnEliminar" runat="server" CssClass="btn btn-blue-alt pull-right"><i class="glyph-icon icon-minus-square"></i> Eliminar</asp:LinkButton>
                            <div class="divider"></div>
                            <h3><i class="glyph-icon icon-table"></i>Tabla de datos</h3>
                            <dx:ASPxGridView ID="gvTabla" runat="server" CssClass="col-lg-12" Theme="iOS" OnFocusedRowChanged="gvTabla_FocusedRowChanged" OnSelectionChanged="gvTabla_SelectionChanged">

                                <SettingsBehavior AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True" />
<SettingsCommandButton>
<ShowAdaptiveDetailButton ButtonType="Image"></ShowAdaptiveDetailButton>

<HideAdaptiveDetailButton ButtonType="Image"></HideAdaptiveDetailButton>
</SettingsCommandButton>

                            </dx:ASPxGridView>
                        </div>
                        <div class="divider"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphBarraLat" runat="server">
    <div id="page-sidebar">
        <div class="scroll-sidebar">
            <ul id="sidebar-menu">
                <li class="header"><span>Módulos</span></li>
                <asp:PlaceHolder ID="phAdmin" runat="server" Visible="true">
                    <li>
                        <a href="../GUI/GestionUsuariosGUI.aspx" title="Usuarios">
                            <i class="glyph-icon icon-users"></i>
                            <span>Usuarios</span>
                        </a>
                    </li>
                    <li>
                        <a href="../GUI/GestionSitios.aspx" title="Sitios">
                            <i class="glyph-icon icon-university"></i>
                            <span>Sitios</span>
                        </a>
                    </li>
                    <li>
                        <a href="../GUI/GestionEstablecimientos.aspx" title="Establecimientos">
                            <i class="glyph-icon icon-building"></i>
                            <span>Establecimientos</span>
                        </a>
                    </li>
                    <li>
                        <a href="../GUI/GestionSuscripciones.aspx" title="Suscripciones">
                            <i class="glyph-icon icon-credit-card   "></i>
                            <span>Suscripciones</span>
                        </a>
                    </li>
                    <li>
                        <a href="../GUI/GestionEventos.aspx" title="Eventos">
                            <i class="glyph-icon icon-puzzle-piece"></i>
                            <span>Eventos</span>
                        </a>
                    </li>
                    <li>
                        <a href="../GUI/GestionDireccion.aspx" title="Direcciones">
                            <i class="glyph-icon icon-road"></i>
                            <span>Direcciones</span>
                        </a>
                    </li>
                    <li>
                        <a href="../GUI/GestionAdministrador.aspx" title="Administradores">
                            <i class="glyph-icon icon-key"></i>
                            <span>Administradores</span>
                        </a>
                    </li>
                </asp:PlaceHolder>

                <asp:PlaceHolder ID="phUsuario" runat="server" Visible="false">

                    <li>
                        <a href="../GUI/GestionUsuariosGUI.aspx" title="Perfil">
                            <i class="glyph-icon icon-users"></i>
                            <span>Perfil</span>
                        </a>
                    </li>
                    <li>
                        <a href="../GUI/GestionEstablecimientos.aspx" title="Establecimientos">
                            <i class="glyph-icon icon-building"></i>
                            <span>Establecimientos</span>
                        </a>
                    </li>
                    <li>
                        <a href="../GUI/GestionEventos.aspx" title="Eventos">
                            <i class="glyph-icon icon-puzzle-piece"></i>
                            <span>Eventos</span>
                        </a>
                    </li>
                    <li>
                        <a href="../GUI/GestionDireccion.aspx" title="Direcciones">
                            <i class="glyph-icon icon-road"></i>
                            <span>Direcciones</span>
                        </a>
                    </li>
                </asp:PlaceHolder>
            </ul>
        </div>
    </div>
</asp:Content>
