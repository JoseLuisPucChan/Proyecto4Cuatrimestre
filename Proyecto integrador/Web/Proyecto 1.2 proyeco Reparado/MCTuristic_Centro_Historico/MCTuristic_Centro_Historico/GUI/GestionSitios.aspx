<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpBase.Master" AutoEventWireup="true" CodeBehind="GestionSitios.aspx.cs" Inherits="MCTuristic_Centro_Historico.GUI.GestionSitios" %>
<asp:Content ID="Content3" ContentPlaceHolderID="cphTituloPagina" runat="server">
    Gestion de sitios
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
                    <h3 class="text-center font-bold"><i class="glyph-icon icon-university"></i>Control de sitios </h3>
                    <div class="divider"></div>
                    <asp:LinkButton ID="lbtnNuevo" runat="server" CssClass="btn btn-blue-alt"><i class="glyph-icon icon-plus-circle"></i> Nuevo</asp:LinkButton>
                    <div class="divider"></div>
                    <div class="col-lg-6">
                        <div class="form-group border-blue">
                            <h3><i class="glyph-icon icon-tag"></i>Nombre</h3>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control border-blue"></asp:TextBox>
                            <br />
                            <h3><i class="glyph-icon icon-list"></i>Tipo de sitio</h3>
                            <asp:DropDownList ID="ddlTipoSitio" runat="server" CssClass="form-control border-blue"></asp:DropDownList>
                            <button class="btn btn-primary" data-toggle="modal" data-target="#Sitio" type="button">Agregar nuevo tipo de sitio</button>
                            <div class="modal fade bs-example-modal-lg" id="Sitio" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
                                <div class="modal-dialog modal-lg">
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                            <h3 class="modal-title"><b>Nuevo tipo de sitios</b></h3>
                                        </div>
                                        <div class="modal-body">
                                            <div class="col-lg-6">
                                                <h3><i class="glyph-icon icon-road"></i>Nombre</h3>
                                                <asp:TextBox ID="txtNombreTipo" runat="server" CssClass="form-control border-blue"></asp:TextBox>
                                                <br />
                                                <h3><i class="glyph-icon icon-tag"></i>Descripción</h3>
                                                <asp:TextBox ID="txtDescripcionTipo" runat="server" CssClass="form-control border-blue"></asp:TextBox>
                                            </div>
                                            <div class="col-lg-12">
                                                <div class="pull-right">
        <script type="text/javascript">
            function GurdarTipoSitio() {
                var actionData = " { 'nombre': '" + $("#<%=txtNombre.ClientID%>")[0].value + "', 'descripcion': '" + $("#<%=txtDescripcion.ClientID%>")[0].value + "'}  ";
                    $.ajax({
                        type: "POST",
                        url: "GestionSitios.aspx/GuardarTipoSitio",
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
                    <div class="col-lg-6">
                        <div class="form-group border-blue">
                            <h3><i class="glyph-icon icon-image"></i>Imagen</h3>
                            <asp:FileUpload ID="fuImagen" runat="server" />
                        </div>
                    </div>
                    <div class="col-lg-12 form-group">
                        <h3><i class="glyph-icon icon-language"></i>Dirección</h3>
                        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                        <asp:TextBox ID="txtLat" runat="server" Visible="false"></asp:TextBox>
                        <asp:TextBox ID="txtlon" runat="server" Visible="false"></asp:TextBox>
                        <div class="example-box-wrapper">
                            <div id="map-basic" style="height: 300px;">
                                <style>html, body, #map {width:100%;height: 100%; margin: 0; padding: 0;}</style>
                        <link type="text/css" rel="stylesheet" href="https://cdn.rawgit.com/markkr125/jsmaps/v0.0.15/library/native/core.native.css" />
                        <script src="https://cdn.rawgit.com/markkr125/jsmaps/v0.0.15/library/core.abstract.js" type="text/javascript">
                        </script>
                        <script src="https://cdn.rawgit.com/markkr125/jsmaps/v0.0.15/library/core.abstract-helper.js" type="text/javascript">
                        </script>
                        <script src="https://cdn.rawgit.com/markkr125/jsmaps/v0.0.15/library/core.js" type="text/javascript">
                        </script>
                        <script src="https://cdn.rawgit.com/markkr125/jsmaps/v0.0.15/library/native/core.native.js" type="text/javascript">
                        </script>
                        <script src="https://cdn.rawgit.com/markkr125/jsmaps/v0.0.15/library/native/core.native-ui.js" type="text/javascript">
                        </script>
                        <script src="https://cdn.rawgit.com/markkr125/jsmaps/v0.0.15/library/native/core.native-helper.js" type="text/javascript">
                        </script>
                        <script src="https://cdn.rawgit.com/markkr125/jsmaps/v0.0.15/library/native/core.native-marker.js" type="text/javascript">
                        </script>
                        <script src="https://cdn.rawgit.com/markkr125/jsmaps/v0.0.15/library/native/core.native-infoWindow.js" type="text/javascript">
                        </script>
                        <script src="https://cdn.rawgit.com/markkr125/jsmaps/v0.0.15/library/native/core.native-vector.js" type="text/javascript">
                        </script>

                                 <script type='text/javascript'>
                                     jsMaps.loader(function () {
                                         var tiles = new jsMaps.Native.Tiles();
                                         tiles.addTileLayer("http://{s}.tile.osm.org/{z}/{x}/{y}.png", ['a', 'b', 'c'], '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap contributors</a>.', 'OpenStreetMap');
                                         tiles.addTileLayer("http://{s}.mqcdn.com/tiles/1.0.0/map/{z}/{x}/{y}.png", ['otile1', 'otile2', 'otile3', 'otile4'], '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap contributors</a>. Tiles courtesy of <a href="http://www.mapquest.com/" target="_blank">MapQuest</a> <img src="https://developer.mapquest.com/content/osm/mq_logo.png">', 'Map Quest');
                                         tiles.addTileLayer("http://{s}.mqcdn.com/tiles/1.0.0/sat/{z}/{x}/{y}.jpg", ['oatile1', 'oatile2', 'oatile3', 'oatile4'], '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap contributors</a>. Tiles courtesy of <a href="http://www.mapquest.com/" target="_blank">MapQuest</a> <img src="https://developer.mapquest.com/content/osm/mq_logo.png">', 'Map Quest Satellite', 19);

                                         var map = jsMaps.api.init(
                                                 '#map',
                                                 'native',
                                                 {
                                                     center: {
                                                         latitude: 20.96619031679367,
                                                         longitude: -89.62263481166997
                                                     },
                                                     zoom: 16,
                                                     mouse_scroll: true,
                                                     zoom_control: true,
                                                     map_type: true
                                                 }, tiles
                                         );
       
                                         jsMaps.api.marker(map, { position: { lat: 20.967131137925147, lng: -89.62250740674176 }, title: 'Catedral Merida', draggable: true });
                                         jsMaps.api.marker(map, { position: { lat: 20.966402067250705, lng: -89.62383107689061 }, title: 'Casa Montejo', draggable: true });
                                     });
</script>

<div id='map'>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-12 form-group">
                        <h3><i class="glyph-icon icon-file-text"></i>Descripción</h3>
                        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control border-blue" TextMode="MultiLine"></asp:TextBox>
                    </div>
                    <div class="col-lg-12 form-group">
                        <h3><i class="glyph-icon icon-exclamation"></i>Sucesos importantes</h3>
                        <asp:TextBox ID="txtSucesos" runat="server" CssClass="form-control border-blue" TextMode="MultiLine"></asp:TextBox>
                    </div>
                    <div class="col-lg-12 form-group">
                        <h3><i class="glyph-icon icon-file-text-o"></i>Historia</h3>
                        <asp:TextBox ID="txtHistoria" runat="server" CssClass="form-control border-blue" TextMode="MultiLine"></asp:TextBox>
                    </div>
                    <div class="col-lg-12 form-group">
                        <div class="divider"></div>

        <script type="text/javascript">
            function GurdarSitio() {
                var actionData = " { 'nombre': '" + $("#<%=txtNombreTipo.ClientID%>")[0].value + "', 'idTipo': '" + $("#<%=ddlTipoSitio.ClientID%>")[0].value + "', 'direccion': '" + $("#<%=txtDireccion.ClientID%>") + "', 'latitud': '" + $("#<%=txtLat.ClientID%>") + "', 'longitud': '" + $("#<%=txtlon.ClientID%>") + "', 'historia': '" + $("#<%=txtHistoria.ClientID%>") + "', 'suceso': '" + $("#<%=txtSucesos.ClientID%>") + "', 'descripcion': '" + $("#<%=txtDescripcion.ClientID%>") + "'}  ";
                    $.ajax({
                        type: "POST",
                        url: "GestionSitios.aspx/GuardarSitio",
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
