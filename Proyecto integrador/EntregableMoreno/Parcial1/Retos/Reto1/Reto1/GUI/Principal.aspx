<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Reto1.GUI.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1" />
    <title></title>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Badge Sign In Form template Responsive, Login form web template,Flat Pricing tables,Flat Drop downs  Sign up Web Templates, Flat Web Templates, Login sign up Responsive web template, SmartPhone Compatible web template, free WebDesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- Custom Theme files -->
    <link href="../Recursos/css/css_bootstrap.css" rel="stylesheet" />
    <link href="../Recursos/css/style.css" rel="stylesheet" />
    
<!-- //Custom Theme files -->
<!-- web font -->
<link href='//fonts.googleapis.com/css?family=Open+Sans:400,300,600,700,800' rel='stylesheet' type='text/css'/>
   <!--web font-->
</head>

   
<body>
    <form id="home" runat="server">
         <script src="../Recursos/js/jquery-3.1.1.min.js" type="text/javascript"></script>

         <!--Ejemplo de crear archivo json-->
<%--   <asp:Label ID="Label4" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
           <asp:Label ID="Label5" runat="server" Text="Edad"></asp:Label>
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
           <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
         <asp:Button ID="Button3" runat="server" Text="GeneraJson" OnClick="Button2_Click" />

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>

        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />--%>

    <!--Obtener el GridView de un archivo json-->
<%--     <asp:Button ID="Button1" runat="server" Text="Button"  />
        <asp:GridView ID="GridView1" runat="server" ForeColor="White"></asp:GridView>
    --%>
        
        
         <!--DropDownlist-->
  <div class="main"> 
                <!--Titulo-->
                    <h1>Búsqueda</h1>
                   <div class="row">
          <!--DropDownlist Estados-->
		        <div class="login-form col-sm-3 margen"> 
	    		<h2>Estado</h2>
			<div class="agileits-top" id="s">
                <div class="styled-input">
					<center>
					<asp:Label ID="Label1" runat="server" Text="Seleccione un Estado..." CssClass="color"></asp:Label>
                        <asp:DropDownList ID="ddlEstados"  ForeColor="#60b699" runat="server" CssClass="color" width="300px" AutoPostBack="True" OnSelectedIndexChanged="ddlEstados_SelectedIndexChanged">

                        </asp:DropDownList>
				</center>
                </div>
			</div>
            </div>
                 <!-- Se activa when el Drop selecciona un nuevo Item-->
           <script type="text/javascript" >
               $("#ddlEstados")
               $("#ddlEstados").change(function () {
                   mivalor = $("#ddlEstados").val();
                   //alert("Han cambiado mi valor = " + mivalor);
                   //--La clase realiza la comunicación directa con el control de manera tiempo real o el ID
                   $("#LblEstado").val(mivalor);
               })
            </script> 
           <!--DropDownlist Municipio-->
        <div class="login-form col-sm-3 margen"> 
			<h2>Municipio</h2>
			<div class="agileits-top">
                <div class="styled-input">
					<center>
					<asp:Label ID="Label2" runat="server" Text="Seleccione un Municipio..." CssClass="color"></asp:Label>
                        <asp:DropDownList ID="ddlMunicipio"  ForeColor="#60b699" runat="server" CssClass="color" width="300px" OnSelectedIndexChanged="ddlMunicipio_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>
                                -----Seleccione Municipio----
                            </asp:ListItem>
                        </asp:DropDownList>
				</center>
                </div>
			</div>
		
            </div>

           <!--DropDownlist Localidad-->
        <div class="login-form col-sm-3 margen"> 
			<h2>Localidad</h2>
			<div class="agileits-top">
                <div class="styled-input">
					<center>
					<asp:Label ID="Label3" runat="server" Text="Seleccione una Localidad..." CssClass="color"></asp:Label>
                        <asp:DropDownList ID="ddlLocalidad"  ForeColor="#60b699" runat="server" CssClass="color" width="300px" AutoPostBack="True">
                           <asp:ListItem>
                                -----Seleccione Localidad----
                            </asp:ListItem>
                        </asp:DropDownList>
				</center>
                    
                </div>
			</div>
           
            </div>
         </div>
	</div>
        
     
       <!---Metodo para obtener el json Prueba--->
        <script type="text/javascript" >
            $(document).ready(function () {
                $.getJSON("datos.json", function (data) {
                    for (u in data.users.user) {
                        $("#ddlLocalidad").append("<option value=" + data.users.user[u].Id +
                                     ">" + data.users.user[u].nombre + "</option>");
                    }
                })

                $("#usuarios").change(function () {
                    var str = "";
                    $("#ddlLocalidad ListItem:selected").each(function () {
                        str = $(this).val();
                    })
                    $("#Label4").text("Ha seleccionado el valor " + str);
                })
            });
        </script> 
    </form>
      
</body>
</html>
