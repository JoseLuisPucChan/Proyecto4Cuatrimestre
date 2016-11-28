<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="VistaProducto.aspx.cs" Inherits="MCTuristic_Centro_Historico.GUI.VistaProducto" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Principal" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Contenido" runat="server">
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
                                                        <li><a tabindex="-1" href="Productos1.aspx">Lista Productos </a></li>
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
                                                    <a href="Contactanos1.aspx">Contactanos<b></b></a>
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

        <section class="products">
            <div class="container">
                <div class="row">

                    <div class="col-lg-9 col-md-9">
                        <div class="pro-title">
                            <h2>Productos</h2>
                            <h4 class="sub-title">Conoce la variedad de productos que nuestro clientes ofrecen.</h4>
                        </div>

                        <div class="gallery">
                        <%--Sección 1--%>
                       <div class="row">
                                <%--Modulo 1--%>
                        
                           <asp:DataList ID="DtlProductos" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" HorizontalAlign="Center" Width="800px">
                               
                                 <FooterStyle VerticalAlign="Top" Wrap="True" />
                               
                                 <ItemTemplate>
                                  
                                   <asp:Label ID="lblidServicio" runat="server" Visible="true" Text='<%# Eval("idServicio") %>' ForeColor="#3399FF"></asp:Label>
                                   
                                    <ul class="pro-box">
                                            <li class="pro">
                                                        <div class="block-image">

                                                    <asp:Image class="img-responsive" ID="Image2"  runat="server" 
                                                    ImageUrl='<%# "GetImagen.aspx?id=" + Eval("idServicio") %>' alt=""  />
                                                           
                                                            <div class="img-overlay-3-up pat-override"></div>
                                                            <div class="img-overlay-3-down pat-override"></div>
                                                            <ol class="static-style">
                                                                <li class="white-rounded">
                                                                    <a href="DetalleProducto.aspx"><i class="fa fa-link"></i></a></li>
                                                                <li class="white-rounded">
                                                                    <a href="images/large/large1.gif" rel="prettyPhoto[gallery1]">
                                                                  <i class="fa fa-plus"></i></a></li>
                                                            </ol>
                                                        </div>
                                                <span class="addtocart">
                                                <a href="DetalleProducto.aspx">Ver Detalles</a>
                                                </span> 
                                            </li>
                                            <li>
                                                <h4><a href="DetalleProducto.aspx"><asp:Label ID="lbl" runat="server" Text='<%# Eval("NombreServ") %>' ForeColor="#3399FF"></asp:Label></a></h4>
                                            </li>
                                    <li>Restaurante flor</li>
                                        <li class="pro-footer">
                                            <span class="price">$<asp:Label ID="lblPrecio" runat="server" Text='<%# Eval("PreciosServicio") %>' ForeColor="#3399FF"></asp:Label></span>
                                                <span class="rating">
                                                <a href="#">
                                                 <i class="fa fa-star">
                                                 </i></a>
                                                <a href="#"><i class="fa fa-star"></i></a>
                                                 <a href="#"><i class="fa fa-star"></i></a>
                                                 <a href="#"><i class="fa fa-star-o"></i></a>
                                                <a href="#">
                                                <i class="fa fa-star-o"></i></a>
                                                </span>
                                        </li>
                                    </ul>
                              
                                       <br />
                                       <br />
                                       <br />
                                       <br />
                               </ItemTemplate>
                             
                                 <SelectedItemStyle Width="200px" />
                             
                                 <SeparatorStyle BackColor="Yellow" Font-Bold="False" Font-Italic="False" Font-Names="Adobe Devanagari" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Bottom" BorderWidth="30px" Font-Size="XX-Small" />
                             
                           </asp:DataList>
                          
                             

                      <%--     <asp:DataList ID="dlEjemplo2" runat="server" Width="562px" OnItemCommand="dlEjemplo2_ItemCommand" OnUpdateCommand="dlEjemplo2_UpdateCommand" OnSelectedIndexChanged="dlEjemplo2_SelectedIndexChanged">         
    <ItemTemplate>
          
          <asp:ImageButton ID="ImageButton1" ImageUrl="~/Recursos/images/perro (1).png" runat="server" OnClick="ImageButton1_Click1" />
               
                        <dx:ASPxSplitter ID="ASPxSplitter1" runat="server" Height="193px" Width="688px">
                            <panes>
                                <dx:SplitterPane>
                                    <ContentCollection>
                                        <dx:SplitterContentControl runat="server">
                                            &nbsp;&nbsp;
                                           <asp:Image class="img-rounded" ID="Image2"  runat="server" 
                                             ImageUrl='<%# "GetImagen.aspx?id=" + Eval("idMascota") %>'  Height="170px" Width="213px"/>
                                         
                                        </dx:SplitterContentControl>
                                    </ContentCollection>
                                </dx:SplitterPane>
                                <dx:SplitterPane>
                                    <ContentCollection>
                                        <dx:SplitterContentControl runat="server">
                                      
                                            <span style="font-size: medium">&nbsp;<asp:Label ID="Label2" runat="server" ForeColor="#3399FF" Text="Se extravio"></asp:Label>
                                            <asp:Label ID="lbl" runat="server" Text='<%# Eval("Especie") %>' ForeColor="#3399FF"></asp:Label>
                                            ,<asp:Label ID="lblRaza" runat="server" Text='<%# Eval("Raza") %>' ForeColor="#3399FF"></asp:Label>
                                            <br />
                                            <br />
                                            &nbsp;<asp:Label ID="Label3" runat="server" Text="Nombre:&nbsp;"></asp:Label>
                                            <asp:Label ID="lblNombre" runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                                            <br />
                                            &nbsp;<asp:Label ID="Label4" runat="server" Text="Edad:"></asp:Label>
                                            <asp:Label ID="lblEdad" runat="server" Text='<%# Eval("Edad") %>'></asp:Label>
                                            <br />
                                            
                                            <asp:Label ID="Label5" runat="server" Text="Sexo:"></asp:Label>
                                            <asp:Label ID="lblSexo" runat="server" Text='<%# Eval("Sexo") %>'></asp:Label>
                                            <br />
                                            &nbsp;<asp:Label ID="Label6" runat="server" Text="Se extravio en:"></asp:Label>
                                            <asp:Label ID="lblSextravio" runat="server" Text='<%# Eval("Ciudad") %>'></asp:Label>,&nbsp;<asp:Label ID="Label1" runat="server" Text='<%# Eval("Estado") %>'></asp:Label>
                                      
                                                &nbsp;&nbsp;&nbsp;&nbsp;</span>&nbsp;&nbsp;&nbsp;&nbsp;
                                            
                                        </dx:SplitterContentControl>
                                    </ContentCollection>
                                </dx:SplitterPane>
                            </panes>
                            <Styles>
                                <HorizontalSeparator Border-BorderStyle="None">
                                </HorizontalSeparator>
                            </Styles>
                            <Border BorderStyle="None" />
                        </dx:ASPxSplitter>
     
                        
                        <br />
                        <br />
                    

                    </ItemTemplate>
    </asp:DataList>

--%>



                            <%--Modulo 2--%>
                          <%--<div class="col-lg-4 col-md-4 col-sm-4">
                                    <ul class="pro-box">
                                        <li class="pro">
                                            <div class="block-image">
                                                <img class="img-responsive" src="../Recursos/Imagenes/2.jpg" alt="" />
                                                <div class="img-overlay-3-up pat-override"></div>
                                                <div class="img-overlay-3-down pat-override"></div>
                                                <ol class="static-style">
                                                    <li class="white-rounded"><a href="DetalleProducto.aspx"><i class="fa fa-link"></i></a></li>
                                                    <li class="white-rounded"><a href="images/large/large1.gif" rel="prettyPhoto[gallery1]"><i class="fa fa-plus"></i></a></li>
                                                </ol>
                                            </div>
                                            <span class="addtocart"><a href="DetalleProducto.aspx">Ver Detalles</a></span> </li>
                                        <li>
                                            <h4><a href="DetalleProducto.aspx">guayaberas</a></h4>
                                        </li>
                                        <li>Camiseria Canul</li>
                                        <li class="pro-footer"><span class="price">$299.00</span> <span class="rating"><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a></span></li>
                                    </ul>
                                </div>--%>

                              <%--Modulo 3--%>
                          <%--<div class="col-lg-4 col-md-4 col-sm-4">
                                    <ul class="pro-box">
                                        <li class="pro">
                                            <div class="block-image">
                                                <img class="img-responsive" src="../Recursos/Imagenes/3.jpg" alt="" />
                                                <div class="img-overlay-3-up pat-override"></div>
                                                <div class="img-overlay-3-down pat-override"></div>
                                                <ol class="static-style">
                                                    <li class="white-rounded"><a href="DetalleProducto.aspx"><i class="fa fa-link"></i></a></li>
                                                    <li class="white-rounded"><a href="images/large/large1.gif" rel="prettyPhoto[gallery1]"><i class="fa fa-plus"></i></a></li>
                                                </ol>
                                            </div>
                                            <span class="addtocart"><a href="DetalleProducto.aspx">Ver Detalles</a></span> </li>
                                        <li>
                                            <h4><a href="DetalleProducto.aspx">Bluza bordada</a></h4>
                                        </li>
                                        <li>Camiseria Canul</li>
                                        <li class="pro-footer"><span class="price">$199.00</span> <span class="rating"><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a></span></li>
                                    </ul>
                                </div>--%>

                        </div>

                            <div class="gap-30"></div>
                             <%--Sección 2--%>
                            <div class="row">

                                <div class="col-lg-4 col-md-4 col-sm-4 cp_load fadeInUp">
                                    <ul class="pro-box">
                                        <li class="pro">
                                            <div class="block-image">
                                                <img class="img-responsive" src="../Recursos/Imagenes/4.jpg" alt="" />
                                                <div class="img-overlay-3-up pat-override"></div>
                                                <div class="img-overlay-3-down pat-override"></div>
                                                <ol class="static-style">
                                                    <li class="white-rounded"><a href="DetalleProducto.aspx"><i class="fa fa-link"></i></a></li>
                                                    <li class="white-rounded"><a href="images/large/large1.gif" rel="prettyPhoto[gallery1]"><i class="fa fa-plus"></i></a></li>
                                                </ol>
                                            </div>
                                            <span class="addtocart"><a href="DetalleProducto.aspx">Ver Detalles</a></span> </li>
                                        <li>
                                            <h4><a href="DetalleProducto.aspx">Hamacas</a></h4>
                                        </li>
                                        <li>Hamacas El Aguacate</li>
                                        <li class="pro-footer"><span class="price">$599.00</span> <span class="rating"><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a></span></li>
                                    </ul>
                                </div>


                                <div class="col-lg-4 col-md-4 col-sm-4 cp_load fadeInUp">
                                    <ul class="pro-box">
                                        <li class="pro">
                                            <div class="block-image">
                                                <img class="img-responsive" src="../Recursos/Imagenes/5.jpg" alt="" />
                                                <div class="img-overlay-3-up pat-override"></div>
                                                <div class="img-overlay-3-down pat-override"></div>
                                                <ol class="static-style">
                                                    <li class="white-rounded"><a href="DetalleProducto.aspx"><i class="fa fa-link"></i></a></li>
                                                    <li class="white-rounded"><a href="images/large/large1.gif" rel="prettyPhoto[gallery1]"><i class="fa fa-plus"></i></a></li>
                                                </ol>
                                            </div>
                                            <span class="addtocart"><a href="DetalleProducto.aspx">Ver Detalles</a></span> </li>
                                        <li>
                                            <h4><a href="DetalleProducto.aspx">cerámica</a></h4>
                                        </li>
                                        <li>Casa san josé Cerámica</li>
                                        <li class="pro-footer"><span class="price">$89.00</span> <span class="rating"><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a></span></li>
                                    </ul>
                                </div>


                                <div class="col-lg-4 col-md-4 col-sm-4 cp_load fadeInUp">
                                    <ul class="pro-box">
                                        <li class="pro">
                                            <div class="block-image">
                                                <img class="img-responsive" src="../Recursos/Imagenes/6.jpg" alt="" />
                                                <div class="img-overlay-3-up pat-override"></div>
                                                <div class="img-overlay-3-down pat-override"></div>
                                                <ol class="static-style">
                                                    <li class="white-rounded"><a href="DetalleProducto.aspx"><i class="fa fa-link"></i></a></li>
                                                    <li class="white-rounded"><a href="images/large/large1.gif" rel="prettyPhoto[gallery1]"><i class="fa fa-plus"></i></a></li>
                                                </ol>
                                            </div>
                                            <span class="addtocart"><a href="DetalleProducto.aspx">Ver Detalles</a></span> </li>
                                        <li>
                                            <h4><a href="DetalleProducto.aspx">Tortillas</a></h4>
                                        </li>
                                        <li>Monino Reyes</li>
                                        <li class="pro-footer"><span class="price">$14.00</span> <span class="rating"><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a></span></li>
                                    </ul>
                                </div>

                            </div>

                            <div class="gap-30"></div>
                             <%--Sección 3--%>
                            <%--<div class="row">

                                <div class="col-lg-4 col-md-4 col-sm-4 cp_load fadeInUp">
                                    <ul class="pro-box">
                                        <li class="pro">
                                            <div class="block-image">

                                                <img class="img-responsive" src="../Recursos/Imagenes/7.jpg" alt="" />
                                                <div class="img-overlay-3-up pat-override"></div>
                                                <div class="img-overlay-3-down pat-override"></div>
                                                <ol class="static-style">
                                                    <li class="white-rounded"><a href="DetalleProducto.aspx"><i class="fa fa-link"></i></a></li>
                                                    <li class="white-rounded"><a href="images/large/large1.gif" rel="prettyPhoto[gallery1]"><i class="fa fa-plus"></i></a></li>
                                                </ol>
                                            </div>
                                            <span class="addtocart"><a href="DetalleProducto.aspx">Ver Detalles</a></span> </li>
                                        <li>
                                            <h4><a href="DetalleProducto.aspx">Empanadas</a></h4>
                                        </li>
                                        <li>Fonda lucas</li>
                                        <li class="pro-footer"><span class="price">$9.00</span> <span class="rating"><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a></span></li>
                                    </ul>
                                </div>


                                <div class="col-lg-4 col-md-4 col-sm-4 cp_load fadeInUp">
                                    <ul class="pro-box">
                                        <li class="pro">
                                            <div class="block-image">
                                                <img class="img-responsive" src="../Recursos/Imagenes/8.jpg" alt="" />
                                                <div class="img-overlay-3-up pat-override"></div>
                                                <div class="img-overlay-3-down pat-override"></div>
                                                <ol class="static-style">
                                                    <li class="white-rounded"><a href="DetalleProducto.aspx"><i class="fa fa-link"></i></a></li>
                                                    <li class="white-rounded"><a href="images/large/large1.gif" rel="prettyPhoto[gallery1]"><i class="fa fa-plus"></i></a></li>
                                                </ol>
                                            </div>
                                            <span class="addtocart"><a href="DetalleProducto.aspx">Ver Detalles</a></span> </li>
                                        <li>
                                            <h4><a href="DetalleProducto.aspx">Hotel</a></h4>
                                        </li>
                                        <li>Holtel Reyes</li>
                                        <li class="pro-footer"><span class="price">$199.00</span> <span class="rating"><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a></span></li>
                                    </ul>
                                </div>


                                <div class="col-lg-4 col-md-4 col-sm-4 cp_load fadeInUp">
                                    <ul class="pro-box">
                                        <li class="pro">
                                            <div class="block-image">
                                                <img class="img-responsive" src="../Recursos/Imagenes/9.jpg" alt="" />
                                                <div class="img-overlay-3-up pat-override"></div>
                                                <div class="img-overlay-3-down pat-override"></div>
                                                <ol class="static-style">
                                                    <li class="white-rounded"><a href="DetalleProducto.aspx"><i class="fa fa-link"></i></a></li>
                                                    <li class="white-rounded"><a href="images/large/large1.gif" rel="prettyPhoto[gallery1]"><i class="fa fa-plus"></i></a></li>
                                                </ol>
                                            </div>
                                            <span class="addtocart"><a href="DetalleProducto.aspx">Ver Detalles</a></span> </li>
                                        <li>
                                            <h4><a href="DetalleProducto.aspx">Hotel</a></h4>
                                        </li>
                                        <li>Hotel Gobernador</li>
                                        <li class="pro-footer"><span class="price">$499.00</span> <span class="rating"><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star-star"></i></a><a href="#"><i class="fa fa-star-star"></i></a><a href="#"><i class="fa fa-star-o"></i></a></span></li>
                                    </ul>
                                </div>

                            </div>--%>

                            <div class="gap-30"></div>

                            <%--<div class="row">

                                <div class="col-lg-4 col-md-4 col-sm-4 cp_load fadeInUp">
                                    <ul class="pro-box">
                                        <li class="pro">
                                            <div class="block-image">

                                                <img class="img-responsive" src="../Recursos/Imagenes/10.jpg" alt="" />
                                                <div class="img-overlay-3-up pat-override"></div>
                                                <div class="img-overlay-3-down pat-override"></div>
                                                <ol class="static-style">
                                                    <li class="white-rounded"><a href="DetalleProducto.aspx"><i class="fa fa-link"></i></a></li>
                                                    <li class="white-rounded"><a href="images/large/large1.gif" rel="prettyPhoto[gallery1]"><i class="fa fa-plus"></i></a></li>
                                                </ol>
                                            </div>
                                            <span class="addtocart"><a href="DetalleProducto.aspx">Ver Detalles</a></span> </li>
                                        <li>
                                            <h4><a href="DetalleProducto.aspx">Massage Equipments</a></h4>
                                        </li>
                                        <li>We have many equipments of massage</li>
                                        <li class="pro-footer"><span class="price">$199.00</span> <span class="rating"><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a></span></li>
                                    </ul>
                                </div>


                                <div class="col-lg-4 col-md-4 col-sm-4 cp_load fadeInUp">
                                    <ul class="pro-box">
                                        <li class="pro">
                                            <div class="block-image">
                                                <img class="img-responsive" src="../Recursos/Imagenes/11.jpg" alt="" />
                                                <div class="img-overlay-3-up pat-override"></div>
                                                <div class="img-overlay-3-down pat-override"></div>
                                                <ol class="static-style">
                                                    <li class="white-rounded"><a href="DetalleProducto.aspx"><i class="fa fa-link"></i></a></li>
                                                    <li class="white-rounded"><a href="images/large/large1.gif" rel="prettyPhoto[gallery1]"><i class="fa fa-plus"></i></a></li>
                                                </ol>
                                            </div>
                                            <span class="addtocart"><a href="DetalleProducto.aspx">Ver Detalles</a></span> </li>
                                        <li>
                                            <h4><a href="DetalleProducto.aspx">Massage Equipments</a></h4>
                                        </li>
                                        <li>We have many equipments of massage</li>
                                        <li class="pro-footer"><span class="price">$199.00</span> <span class="rating"><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a></span></li>
                                    </ul>
                                </div>


                                <div class="col-lg-4 col-md-4 col-sm-4 cp_load fadeInUp">
                                    <ul class="pro-box">
                                        <li class="pro">
                                            <div class="block-image">
                                                <img class="img-responsive" src="../Recursos/Imagenes/12.jpg" alt="" />
                                                <div class="img-overlay-3-up pat-override"></div>
                                                <div class="img-overlay-3-down pat-override"></div>
                                                <ol class="static-style">
                                                    <li class="white-rounded"><a href="DetalleProducto.aspx"><i class="fa fa-link"></i></a></li>
                                                    <li class="white-rounded"><a href="images/large/large1.gif" rel="prettyPhoto[gallery1]"><i class="fa fa-plus"></i></a></li>
                                                </ol>
                                            </div>
                                            <span class="addtocart"><a href="DetalleProducto.aspx">Ver Detalles</a></span> </li>
                                        <li>
                                            <h4><a href="DetalleProducto.aspx">Massage Equipments</a></h4>
                                        </li>
                                        <li>We have many equipments of massage</li>
                                        <li class="pro-footer"><span class="price">$199.00</span> <span class="rating"><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a><a href="#"><i class="fa fa-star-o"></i></a></span></li>
                                    </ul>
                                </div>

                            </div>--%>

                        </div>


                        <div class="gap-30"></div>



                        <div class="paging">
                            <ul class="pagination">
                                <li><a href="#"><i class="fa fa-angle-left"></i></a></li>
                                <li><a href="#">1</a></li>
                                
                                <li><a href="#"><i class="fa fa-angle-right"></i></a></li>
                            </ul>
                        </div>
                    </div>


                    <div class="col-lg-3 col-md-3 sidebar">

                        <div class="search">
                            <form>
                                <input name="" type="text" placeholder="Search for:">
                                <button><i class="fa fa-search"></i></button>
                            </form>
                        </div>


                        <%--<div class="services-list"> <strong class="stitle">Latest Posts</strong>
<ul class="slist">
<li class="simg"><img src="images/twuser-1.jpg"></li>
<li class="spost"> <strong>Lorem Ipsum dolar sit</strong>
<p>Sed tristique in urna nec ullamcorper integer egestas accumsan elit.</p>
</li>
</ul>
<ul class="slist">
<li class="simg"><img src="images/fp4.jpg"></li>
<li class="spost"> <strong>Lorem Ipsum dolar sit</strong>
<p>Sed tristique in urna nec ullamcorper integer egestas accumsan elit.</p>
</li>
</ul>
<ul class="slist">
<li class="simg"><img src="images/twuser-3.jpg"></li>
<li class="spost"> <strong>Lorem Ipsum dolar sit</strong>
<p>Sed tristique in urna nec ullamcorper integer egestas accumsan elit.</p>
</li>
</ul>
<ul class="slist">
<li class="simg"><img src="images/fp7.jpg"></li>
<li class="spost"> <strong>Lorem Ipsum dolar sit</strong>
<p>Sed tristique in urna nec ullamcorper integer egestas accumsan elit.</p>
</li>
</ul>
</div>--%>

                        <div class="gap-30"></div>

                        <div class="ser-cats">
                            <strong class="stitle">Categorias</strong>
                            <ul>
                                <li><a href="#">Comida</a></li>
                                <li><a href="#">Hoteles</a></li>
                                <li><a href="#">Belleza</a></li>
                                <li><a href="#">Cultura</a></li>
                                <li><a href="#">Souvenirs</a></li>
                                <li><a href="#">Ropa Tradicional</a></li>

                            </ul>
                        </div>


                        <%--<div>
<div class="gap-30"></div>
<strong class="stitle">Flickr Images</strong>
<ul class="lb-album">
<li> <a href="#image-1"> <img src="images/fp1.jpg" alt="image01"> <span><i class="fa fa-search-plus"></i></span> </a>
<div class="lb-overlay" id="image-1"> <img src="images/large/large1.gif" alt="image01">
<div>
<p>Image Tagline Will Come here</p>
</div>
<a href="#page" class="lb-close"><i class="fa fa-times-circle"></i></a> </div>
</li>
<li> <a href="#image-2"> <img src="images/fp2.jpg" alt="image01"> <span><i class="fa fa-search-plus"></i></span> </a>
<div class="lb-overlay" id="image-2"> <img src="images/large/large1.gif" alt="image01">
<div>
<p>Image Tagline Will Come here</p>
</div>
<a href="#page" class="lb-close"><i class="fa fa-times-circle"></i></a> </div>
</li>
<li> <a href="#image-3"> <img src="images/fp3.html" alt="image01"> <span><i class="fa fa-search-plus"></i></span> </a>
<div class="lb-overlay" id="image-3"> <img src="images/large/large1.gif" alt="image01">
<div>
<p>Image Tagline Will Come here</p>
</div>
<a href="#page" class="lb-close"><i class="fa fa-times-circle"></i></a> </div>
</li>
<li> <a href="#image-4"> <img src="images/fp4.jpg" alt="image01"> <span><i class="fa fa-search-plus"></i></span> </a>
<div class="lb-overlay" id="image-4"> <img src="images/large/large1.gif" alt="image01">
<div>
<p>Image Tagline Will Come here</p>
</div>
<a href="#page" class="lb-close"><i class="fa fa-times-circle"></i></a> </div>
</li>
<li> <a href="#image-5"> <img src="images/fp5.jpg" alt="image01"> <span><i class="fa fa-search-plus"></i></span> </a>
<div class="lb-overlay" id="image-5"> <img src="images/large/large1.gif" alt="image01">
<div>
<p>Image Tagline Will Come here</p>
</div>
<a href="#page" class="lb-close"><i class="fa fa-times-circle"></i></a> </div>
</li>
<li> <a href="#image-6"> <img src="images/fp1.jpg" alt="image01"> <span><i class="fa fa-search-plus"></i></span> </a>
<div class="lb-overlay" id="image-6"> <img src="images/large/large1.gif" alt="image01">
<div>
<p>Image Tagline Will Come here</p>
</div>
<a href="#page" class="lb-close"><i class="fa fa-times-circle"></i></a> </div>
</li>
<li> <a href="#image-7"> <img src="images/fp7.jpg" alt="image01"> <span><i class="fa fa-search-plus"></i></span> </a>
<div class="lb-overlay" id="image-7"> <img src="images/large/large1.gif" alt="image01">
<div>
<p>Image Tagline Will Come here</p>
</div>
<a href="#page" class="lb-close"><i class="fa fa-times-circle"></i></a> </div>
</li>
<li> <a href="#image-8"> <img src="images/fp8.jpg" alt="image01"> <span><i class="fa fa-search-plus"></i></span> </a>
<div class="lb-overlay" id="image-8"> <img src="images/large/large1.gif" alt="image01">
<div>
<p>Image Tagline Will Come here</p>
</div>
<a href="#page" class="lb-close"><i class="fa fa-times-circle"></i></a> </div>
</li>
<li> <a href="#image-9"> <img src="images/fp9.jpg" alt="image01"> <span><i class="fa fa-search-plus"></i></span> </a>
<div class="lb-overlay" id="image-9"> <img src="images/large/large1.gif" alt="image01">
<div>
<p>Image Tagline Will Come here</p>
</div>
<a href="#page" class="lb-close"><i class="fa fa-times-circle"></i></a> </div>
</li>
</ul>
</div>--%>

                        <div class="gap-30"></div>

                        <div class="archives">
                            <strong class="stitle">Archives</strong>
                            <ul class="office-time">
                                <li>January <span>2014 (04)</span> </li>
                                <li>December<span>2013 (04)</span> </li>
                                <li>November <span>2013 (04)</span></li>
                                <li>October <span>2013 (04)</span></li>
                                <li>September <span>2013 (04)</span></li>
                                <li>August <span>2013 (04)</span></li>
                            </ul>
                        </div>

                        <div class="gap-30"></div>

                        <div class="facebook-box">
                            <strong class="stitle">Facebook</strong>
                            <iframe src="http://www.facebook.com/plugins/likebox.php?href=http%3A%2F%2Fwww.facebook.com%2FFacebookDevelopers&amp;width&amp;height=258&amp;colorscheme=light&amp;show_faces=true&amp;header=false&amp;stream=false&amp;show_border=true&amp;appId=133982306765662" scrolling="no" frameborder="0" style="border: none; overflow: hidden; height: 258px;" allowtransparency="true"></iframe>
                        </div>

                    </div>

                </div>
            </div>
        </section>

        <div class="gap"></div>

    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="scrip" runat="server">
</asp:Content>
