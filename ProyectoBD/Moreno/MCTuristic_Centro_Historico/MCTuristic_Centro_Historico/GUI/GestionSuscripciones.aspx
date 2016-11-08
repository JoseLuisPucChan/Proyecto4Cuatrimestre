<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpBase.Master" AutoEventWireup="true" CodeBehind="GestionSuscripciones.aspx.cs" Inherits="MCTuristic_Centro_Historico.GUI.GestionSuscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTituloPagina" runat="server">
    Gestión de suscripciones
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
<asp:Content ID="Content3" ContentPlaceHolderID="cphBody" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <div class="panel-body">
                    <h3 class="text-center font-bold"><i class="glyph-icon icon-building"></i> Control de suscripciones</h3>
                    <div class="divider"></div>
                    <asp:LinkButton ID="lbtnNuevo" runat="server" CssClass="btn btn-blue-alt"><i class="glyph-icon icon-plus-circle"></i> Nuevo</asp:LinkButton>
                    <div class="divider"></div>
                    <div class="col-lg-6">
                        <div class="form-group border-blue">
                            <h3><i class="glyph-icon icon-tag"></i> Nombre</h3>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control border-blue"></asp:TextBox>
                            <br />
                            <h3><i class="glyph-icon icon-calendar"></i> Fecha de pago</h3>
                            <br />
                                <div class="input-prepend input-group">
                                    <asp:TextBox ID="txtFecha" class="bootstrap-datepicker form-control" runat="server"></asp:TextBox>
                                </div>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group border-blue">
                            <h3><i class="glyph-icon icon-cutlery"></i> Tipo de suscripción</h3>
                            <asp:DropDownList ID="ddlSuscripcion" runat="server" CssClass="form-control border-blue"></asp:DropDownList>
                            <button class="btn btn-primary" data-toggle="modal" data-target="#Direccion" type="button">Agregar nuevo tipo de suscripción</button>
                            <div class="modal fade bs-example-modal-lg" id="Direccion" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
                                <div class="modal-dialog modal-lg">
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                            <h3 class="modal-title"><b>Registrar tipo de suscripción</b></h3>
                                        </div>
                                        <div class="modal-body">
                                            <div class="col-lg-6">
                                                <h3><i class="glyph-icon icon-tag"></i> Nombre</h3>
                                                <asp:TextBox ID="txtNombreTipo" runat="server" CssClass="form-control border-blue"></asp:TextBox>
                                                <br />
                                                <h3><i class="glyph-icon icon-money"></i> Monto</h3>
                                                <asp:TextBox ID="txtMonto" runat="server" CssClass="form-control border-blue"></asp:TextBox>
                                                <br />
                                                <h3><i class="glyph-icon icon-flag"></i> Tiempo de suscripción</h3>
                                                <asp:DropDownList ID="ddlTiempo" runat="server">
                                                    <asp:ListItem Value="1 mes"></asp:ListItem>
                                                    <asp:ListItem Value="3 meses"></asp:ListItem>
                                                    <asp:ListItem Value="6 meses"></asp:ListItem>
                                                    <asp:ListItem Value="1 año"></asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <div class="col-lg-12">
                                                <div class="pull-right">
                                                    <asp:Button ID="btnAceptar" CssClass="btn btn-primary" runat="server" Text="Aceptar" />
                                                    <button type="button" class="btn btn-primary" data-dismiss="modal">Cancelar</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="modal-footer no-border">
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-12 form-group">
                        <div class="divider"></div>
                        <asp:LinkButton ID="lbtnGuardar" runat="server" CssClass="btn btn-blue-alt"><i class="glyph-icon icon-save"></i> Guardar</asp:LinkButton>
                        <asp:LinkButton ID="lbtnModificar" runat="server" CssClass="btn btn-blue-alt"><i class="glyph-icon icon-edit"></i> Modificar</asp:LinkButton>
                        <asp:LinkButton ID="lbtnEliminar" runat="server" CssClass="btn btn-blue-alt pull-right"><i class="glyph-icon icon-minus-square"></i> Eliminar</asp:LinkButton>
                        <div class="divider"></div>
                        <h3><i class="glyph-icon icon-table"></i>Tabla de datos</h3>
                        <asp:GridView ID="gvDatos" runat="server" CssClass="table-bordered form-control"></asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
