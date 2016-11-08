﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="PagPrincipal.aspx.cs" Inherits="MCTuristic_Centro_Historico.GUI.PagPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <header id="header">
   <div class="container">
                <div class="row">
                    <div class="col-lg-3 col-md-3">
                        <logo><a href="PagPrincipal.aspx">
                            <strong class="logo-home"> MCTuristic</strong></a>
                        </logo>
                    </div>
                    <div class="col-lg-9 col-md-9">


                        <div class="home-menu">
                            <div class="navbar mm">
                                <div>
                                    <nav class="navbar navbar-default" role="navigation">

                                        <div class="navbar-header">
                                            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navbar-collapse-1"> <span class="sr-only">Toggle navigation</span> <span class="icon-bar"></span> <span class="icon-bar"></span> <span class="icon-bar"></span> </button>
                                        </div>
                                        <div id="navbar-collapse-1" class="collapse navbar-collapse pull-right">
                                            <ul class="nav navbar-nav">
                                                <li><a href="PagPrincipal.aspx" >Inicio</a></li>
                                                <li class="dropdown">
                                                    <a href="QuieneSomo.aspx" data-toggle="dropdown" class="dropdown-toggle">Servicios<b class="caret"></b></a>
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
                                                                    </ul>
                                                                </div>
                                                            </div>
                                                        </li>
                                                    </ul>
                                                </li>

                                                <li class="dropdown">
                                                    <a href="#" data-toggle="dropdown" class="dropdown-toggle">BLOG<b class="caret"></b></a>
                                                    <ul role="menu" class="dropdown-menu">
                                                        <li><a tabindex="-1" href="blog-full.html"> Full Width </a></li>
                                                        <li><a tabindex="-1" href="blog-masanary.html"> Masonry Style </a></li>
                                                        <li><a tabindex="-1" href="blog.html"> Single Column (With Sidebar) </a></li>
                                                        <li><a tabindex="-1" href="blog-02-column.html"> Double Column</a></li>
                                                        <li><a tabindex="-1" href="blog-03-column.html"> Three Column</a></li>
                                                    </ul>
                                                </li>


                                                <li class="dropdown">
                                                    <a href="Productos.aspx" data-toggle="dropdown" class="dropdown-toggle">Productos<b class="caret"></b></a>
                                                    <ul role="menu" class="dropdown-menu">
                                                       <li><a tabindex="-1"  href="Productos.aspx"> Lista Productos </a></li>
                                                        <li><a tabindex="-1" href="product-details.html"> Product Details</a></li>
                                                        <li><a tabindex="-1" href="cart.html"> Cart </a></li>
                                                        <li><a tabindex="-1" href="checkout.html"> Check Out</a></li>
                                                        <li><a tabindex="-1" href="register.html"> Login</a></li>
                                                        <li><a tabindex="-1" href="register.html"> Register</a></li>
                                                    </ul>
                                                </li>


                                                <li class="dropdown">
                                                    <a href="#" data-toggle="dropdown" class="dropdown-toggle">Gallery<b class="caret"></b></a>
                                                    <ul role="menu" class="dropdown-menu">
                                                        <li><a tabindex="-1" href="galletry01.html"> Double Column </a></li>
                                                        <li><a tabindex="-1" href="galletry02.html"> Three Column</a></li>
                                                        <li><a tabindex="-1" href="galletry03.html"> Four Column</a></li>
                                                        <li><a tabindex="-1" href="galletry04.html"> Masonry Style</a></li>
                                                    </ul>
                                                </li>


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
    <!--Carrucel-->
<section class="main-slider">
            <div class="slider">
                <ul class="header-slider">
                    <li>
                        <div class="slider-text">
                            <h1>Catedral de Yucatán</h1>
                            <p> La obra fue levantada entre 1562 y 1599, luego de la autorización del Papa Pío IV y de la petición del rey Felipe II, se erigió en catedral a la iglesia de la capital del Yucatán.</p>
                        </div>
                        <span>
                            <img src="../Recursos/Imagenes/slider01.jpeg" title="Funky roots" alt="" />
                           
                        </span>
                    </li>
                    <li>
                        <div class="slider-text">
                            <h1>Monumento a la Patria</h1>
                            <p>Es obra del escultor Romulo Rozo, quien a través de esta obra nos muestra parte de la historia de México, desde la fundación de Tenochtitlán hasta mediados del siglo XX.</p>
                        </div>
                        <span>
                            <img src="../Recursos/Imagenes/slider02.jpg"  title="Happy trees" alt="" />
                            
                            </span>
                    </li>
                  
                    <li>
                        <div class="slider-text">
                            <h1>Mérida</h1>
                            <p>Su historia se cuenta a través de su arquitectura, nos llevan de la mano para contarnos sus historias de conquistas, tesoros y riquezas que se han escrito desde mucho antes de la colonización española.</p>
                        </div>
                        <span>
                            <img src="../Recursos/Imagenes/slider03.jpg" title="Happy trees" alt="" />
                            </span>
                    </li>
                </ul>

            </div>
        </section>

    <!--Bienvenida-->
   <section>
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 col-md-12">
                        <div class="welcome">
                            <h2 class="main-title">Bienvenido a Rutas del Centro Histórico </h2>
                            <p class="welcome-txt">
                               Bienvenido a nuestro sitio web, desde aquí podrás consultar toda la información turística del centro histórico de Mérida  Yucatán, hacer
                               su reservación de Hotel en línea pagando con tarjeta de crédito, enterarse de los eventos más importantes y actividades de ecoturismo, consultar mapas y mucho más. 
                            </p>
                            <button onclick="window.location.href='aboutus-01.html'">Leer más</button>
                        </div>
                    </div>
                </div>
            </div>
        </section>
     <!--Carrucel-->
   <div class="mtop1"></div>
</asp:Content>

<asp:Content ID="Content3"  ContentPlaceHolderID ="Contenido" runat="server">
    <section class="inner-titlebg">
<div class="container">
<div class="row">
<div class="col-lg-12 col-md-12">
<h1>Servicios</h1>
</div>
</div>
</div>
</section>
    <div class="gap"></div>
   <section class="services">
<div class="container">
<div class="row">
<div class="col-lg-12 col-md-12">
<h2 class="main-title">SERVICIOS DESTACADOS</h2>
<h4 class="sub-title">Buscamos mejorar cada uno de nuestro servicios para una mejor atención.</h4>
</div>
</div>
<div class="row service-grid">
<div class="col-sm-3">
<ul>
<li><span><i class="fa fa-male"></i> <i class="fa fa-female"></i></span></li>
<li>
<h3>Registra tu negocio</h3>
<p>Podras administrar tu propio negocio para obtener más clientes y mejor prestigio</p>
</li>
<li>
<button onclick="window.location.href='services-details.html'">Leer más</button>
</li>
</ul>
</div>
<div class="col-sm-3">
<ul>
<li><span><i class="fa fa-user-md"></i></span></li>
<li>
<h3>Soporte ténico</h3>
<p>Podra obtener soporte para su cuenta y aclaraciones en sus rutas o lugares favoritos. </p>
</li>
<li>
<button onclick="window.location.href='services-details.html'">Leer más</button>
</li>
</ul>
</div>
<div class="col-sm-3">
<ul>
<li><span><i class="fa fa-gift"></i></span></li>
<li>
<h3>Servicios en oferta</h3>
<p>Conoce los servicios que esten en oferta para poder ahorar en el centro historico. </p>
</li>
<li>
<button onclick="window.location.href='services-details.html'">Leer más</button>
</li>
</ul>
</div>
<div class="col-sm-3">
<ul>
<li><span><i class="fa fa-lightbulb-o"></i></span></li>
<li>
<h3>Conoce los puntos de mérida</h3>
<p>Conoce los espacios mas visitados y reconocidos en el centro histórico. </p>
</li>
<li>
<button onclick="window.location.href='services-details.html'">Leer más</button>
</li>
</ul>
</div>
</div>
<div class="gap-35"></div>
<div class="row">
<div class="col-lg-6 col-md-6">
<strong>Acerca de Nuestros Servicios</strong>
<div class="panel-group" id="accordion">
<div class="panel panel-default">
<div class="panel-heading">
<h4 class="panel-title">
<a data-toggle="collapse" data-parent="#accordion" href="#collapseOne">
Rutas Centro histórico
</a>
</h4>
</div>
<div id="collapseOne" class="panel-collapse collapse in">
<div class="panel-body">
Buscamos una mejor experiencia mientras visitas Yucatán, atravez de este sitio podras encontrar
  los sitios más importantes y podras conocer su historia atraves de el tiempo, su cultura y que acontencimiento sucedieron en 
    el lugar.
</div>
</div>
</div>
<div class="panel panel-default">
<div class="panel-heading">
<h4 class="panel-title">
<a data-toggle="collapse" class="collapsed" data-parent="#accordion" href="#collapseTwo">
Lugares de Hospedaje y comida
</a>
</h4>
</div>
<div id="collapseTwo" class="panel-collapse collapse">
<div class="panel-body">
Buscamos ayudar para poder hacer de tu visita la mejor experiencia, puesto que reunimos los lugares sercanos 
    en el centro histórico, podras conocer sus ofertas y sus mejores precios.
    Podras visualizar una gran variedad de lugares para hospedarse o tener una agradeble cena.
</div>
</div>
</div>
<div class="panel panel-default">
<div class="panel-heading">
<h4 class="panel-title">
<a data-toggle="collapse" class="collapsed" data-parent="#accordion" href="#collapseThree">
Eventos relevantes 

</a>
</h4>
</div>
<div id="collapseThree" class="panel-collapse collapse">
<div class="panel-body">
Podras conocer sobre los eventos que se llevan acabo en sitios históricos, como los horios, fecha de inicio y descripción.
Al igual que la biciruta para conocer los horarios y sitios de reunión

</div>
</div>
</div>
</div>
</div>
<div class="col-lg-6 col-md-6">
<strong>Otras características</strong>
<p>Administración de tu negocio y publicación de tus productos sus caracteristicas precios y ofertas
     tambien podras ofrecer servcios para el publico, al igual que podras gestionar tus propios eventos programados
    en cualquier punto del centro historico.
     
</p>
<ul class="flist">
<li> Ofertas.</li>
<li> Productos bajo costo. </li>
<li> Las mejores platos regionales. </li>
<li> Lugares para hospedarse. </li>
<li> Lugares de recreación y cultura.</li>
 <li> Turibus.</li>
<li> Eventos destacados.</li>
<li> biciruta.</li>

</ul>
</div>
</div>
</div></section>
 <div class="gap"></div>
    <!--Suscripciones-->

    <section class="about">
<div class="container">
<div class="row">
<div class="col-lg-12 col-md-12">
<h2 class="main-title">Suscripciones</h2>
<h4 class="sub-title">Suscribete para poder obtener beneficios y facilidad para la administración de tu negocio.</h4>
</div>
</div>
 
<div class="row">
<div id="pricing-table" class="clear">
<div class="col-lg-3 col-md-3 col-sm-6">
<div class="plan" >
<h3>Gratis<span><i>$</i><strong>0</strong>/3m</span> </h3>
<ul>
<li>Durante 3 meses</li>
<li>Inner Quest</li>
<li>Harmony</li>
<li>Kinetic Flow</li>
<li>Psychic Massage</li>
</ul>
 
<button>Adquirir Ahora</button>
</div>
</div>
<div class="col-lg-3 col-md-3  col-sm-6">
<div class="plan green">
<h3>Basico<span><i>$</i><strong>300</strong>/m</span> </h3>
<ul>
<li>Durante 1 meses</li>
<li>Inner Quest</li>
<li>Harmony</li>
<li>Kinetic Flow</li>
<li>Psychic Massage</li>
</ul>
<button>Adquirir Ahora</button>
</div>
</div>
<div class="col-lg-3 col-md-3 col-sm-6">
<div class="plan blue">
<h3>Medio<span><i>$</i><strong>1300</strong>/s</span> </h3>
<ul>
<li>Durante 6 meses</li>
<li>Inner Quest</li>
<li>Harmony</li>
<li>Kinetic Flow</li>
<li>Psychic Massage</li>
</ul>
<button>Adquirir Ahora</button>
</div>
</div>
<div class="col-lg-3 col-md-3 col-sm-6">
<div class="plan yellow">
<h3>Completo<span><i>$</i><strong>3000</strong>/a</span> </h3>
<ul>
<li>Duenrante 1 año</li>
<li>Inner Quest</li>
<li>Harmony</li>
<li>Kinetic Flow</li>
<li>Psychic Massage</li>
</ul>
<button>Adquirir Ahora</button>
</div>
</div>
</div>
</div>
 
</div>
</section>
     <div class="gap"></div>


</asp:Content>
