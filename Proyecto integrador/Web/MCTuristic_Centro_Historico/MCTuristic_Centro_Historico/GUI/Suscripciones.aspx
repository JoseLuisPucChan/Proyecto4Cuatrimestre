<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="Suscripciones.aspx.cs" Inherits="MCTuristic_Centro_Historico.GUI.Suscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Principal" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Contenido" runat="server">
 <div class="wrapper inner">
<section class="inner-titlebg">
<div class="container">
<div class="row">
<div class="col-lg-12 col-md-12">
<h2>Tabla Suscripciones</h2>
</div>
<div>
<div class="col-lg-9 col-md-9">
<h5>Conoce los precios más adecuados para poder gestionar tus eventos y establecimiento.</h5>
</div>
<div class="col-lg-3 col-md-3">
<ul class="bcrumb pull-right">
<li> <a href="#">Inicio </a></li>
&gt;
<li><a href="#">Tabla Suscripciones</a></li>
</ul>
</div>
</div>
</div>
</div>
</section>
 
<div class="gap"></div>
 
<section class="about">
<div class="container">
<div class="row">
<div class="col-lg-12 col-md-12">
<h2 class="main-title">Tabla Suscripciones</h2>
<h4 class="sub-title">Elige el primer plan gratis durante 3 meses por ser un nuevo usuario</h4>
</div>
</div>
 
<div class="row">
<div class="pricing_table pricing-01">
<ul class="col-lg-3 col-md-3 col-sm-6  price-col-1">
<li>Gratis</li>
<li>
<h2>$0</h2>
<span>Per Month</span> </li>
<li> Anasazi Ubtan </li>
<li class="odd">Turquoise Dreaming </li>
<li>Rosemary Vitality </li>
<li class="odd">Prickly Pear Butter Wrap </li>
<li>Herbal Detoxification Poultice </li>
<li class="last" >
<asp:Button ID="Button1" Width="264"  OnClick="Button3_Click" runat="server" Text="Adquirir ahora" />
   
</li>
</ul>
<ul class="col-lg-3 col-md-3 col-sm-6 price-col-2">
<li>Medium</li>
<li>
<h2>$449.00</h2>
<span>Per Month</span> </li>
<li>Abhyanga and Shirodhara</li>
<li class="odd">Custom Massage</li>
<li>Swedish Massage</li>
<li class="odd">Deep Tissue Massage</li>
<li>Lymphatic Drainage</li>
<li class="last">
<asp:Button ID="Button2" Width="264" runat="server" Text="Adquirir ahora" />
</li>
</ul>
<ul class="col-lg-3 col-md-3 col-sm-6 price-col-3">
<li>Premium</li>
<li>
<h2>$555.00</h2>
<span>Per Month</span> </li>
<li>Journeyman's Facial</li>
<li class="odd">Calming Facial</li>
<li>Rejuvenating Facial</li>
<li class="odd">Makeup Consultation</li>
<li>Elevate Your Facial</li>
<li class="last">
<asp:Button ID="Button3" Width="264" runat="server" Text="Adquirir ahora" />
</li>
</ul>
<ul class="col-lg-3 col-md-3 col-sm-6 price-col-4">
<li>Gold</li>
<li>
<h2>$600.00</h2>
<span>Per Month</span> </li>
<li>Soul Seeker</li>
<li class="odd">Inner Quest</li>
<li>Harmony</li>
<li class="odd">Kinetic Flow</li>
<li>Psychic Massage</li>
<li class="last">
<asp:Button ID="Button4" Width="264" runat="server" Text="Adquirir ahora" />
</li>
</ul>
</div>
</div>
 
</div>
</section>
 
<div class="gap"></div>
 

 
</div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="scrip" runat="server">
</asp:Content>
