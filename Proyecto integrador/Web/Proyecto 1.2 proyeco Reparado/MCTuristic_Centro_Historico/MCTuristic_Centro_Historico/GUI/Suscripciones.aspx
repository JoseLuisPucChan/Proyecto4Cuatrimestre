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

<span>Durante 3 meses</span> </li>
<li> Visualizar sitios </li>
<li class="odd">Publicar eventos </li>
<li>isualización de sugerencias </li>
<li class="odd">-</li>
<li>-</li>
 <li class="odd">-</li>


<li class="last" >
<asp:Button ID="btnGratis" Width="264"  runat="server" Text="Adquirir ahora" OnClick="btnGratis_Click" />
</li>
</ul>
<ul class="col-lg-3 col-md-3 col-sm-6 price-col-2">
<li>Medium</li>
<li>
<h2>$100.00</h2>
<span>Durante 1 meses</span> </li> 
<li>Visualizar sitios</li>
<li class="odd">Publicar eventos</li>
  <li>Visualización de sugerencias</li>
<li class="odd">Registrar establecimientos 1</li>
  <li>-</li>
   <li class="odd">-</li>
<li class="last">
<asp:Button ID="Button2" Width="264" runat="server" Text="Adquirir ahora" OnClick="Button2_Click" />
</li>
</ul>
<ul class="col-lg-3 col-md-3 col-sm-6 price-col-3">
<li>Premium</li>
<li>
<h2>$400.00</h2>
<span>Durante 6 meses</span> </li>
<li>Visualizar sitios</li>
<li class="odd">Publicar eventos</li>
  <li>Visualización de sugerencias</li>
<li class="odd">Registrar establecimientos 5</li>
  <li>Soporte técnico</li>
   <li class="odd">Opciones de edición</li>
<li class="last">
<asp:Button ID="Button3" Width="264" runat="server" Text="Adquirir ahora" OnClick="Button3_Click" />
</li>
</ul>
<ul class="col-lg-3 col-md-3 col-sm-6 price-col-4">
<li>Gold</li>
<li>
<h2>$1000.00</h2>
<span>Durante 1 año</span> </li>
<li>Visualizar sitios</li>
<li class="odd">Publicar eventos</li>
  <li>Visualización de sugerencias</li>
<li class="odd">Registrar establecimientos 5</li>
  <li>Soporte técnico</li>
   <li class="odd">Opciones de edición</li>
<li class="last">
<asp:Button ID="Button4" Width="264" runat="server" Text="Adquirir ahora" OnClick="Button4_Click" />
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
