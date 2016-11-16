<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MCTuristic_Centro_Historico.GUI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio de sesión</title>
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
		<!--[if lte IE 8]><script src="assets/js/html5shiv.js"></script><![endif]-->
    <link href="../Recursos/css/assets/css/main.css" rel="stylesheet" />
    <link rel="stylesheet" href="assets1/css/main.css" />
    <link href="../Recursos/css/assets/css/materialize.css" rel="stylesheet" />
		<!--[if lte IE 9]><link rel="stylesheet" href="assets/css/ie9.css" /><![endif]-->
		<!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
		<noscript><link href="../Recursos/css/assets/css/noscript.css" rel="stylesheet" /></noscript>
    <script src="../Recursos/js/jquery-3.1.1.min.js"></script>

      

  <link href="../demo.geekslabs.com/materialize/v2.1/layout03/css/materialize.css" rel="stylesheet" type="text/css" media="screen,projection" /> 
  <link href="../demo.geekslabs.com/materialize/v2.1/layout03/css/style.css" rel="stylesheet" type="text/css"  media="screen,projection" />
  <link href="../demo.geekslabs.com/materialize/v2.1/layout03/css/custom-style.css" rel="stylesheet" type="text/css" media="screen,projection" />
  <link href="../demo.geekslabs.com/materialize/v2.1/layout03/css/style-horizontal.css" rel="stylesheet" type="text/css" media="screen,projection" />
</head>
<body class="is-loading">
    <form id="form1" runat="server">
    <div>
        <!-- Wrapper -->
			<div id="wrapper">
				<!-- Main -->
					<section id="main">
						<header>
							<span class="avatar"><img src="../images1/hombre.png" alt="" /></span>
						</header>
						<h3>Iniciar seseión</h3>				
							<div class="field">
                                <asp:TextBox type="text" ID="txtEmail" placeholder="Email" runat="server"></asp:TextBox>
							</div>
							<div class="field">
                                <asp:TextBox ID="txtContraseña" type="password" runat="server" placeholder="Contraseña" ></asp:TextBox>

							</div>
							<div class="field">
								<input type="checkbox" id="human" name="human" /><label for="human">Recordarmé</label>
							</div>
							<ul class="actions">

								<li>
                                    <input id="Button1" type="button" class="button" onclick="VerficarUser();"  value="Ingresar" />
                                   <script type="text/javascript">
                                       function VerficarUser() {
                                           var actionData = " { 'email': '" + $("#<%=txtEmail.ClientID%>")[0].value + "'  , 'contraseña': '" + $("#<%=txtContraseña.ClientID%>")[0].value + "' }  ";
                                          $.ajax({
                                              type: "POST",
                                              url: "Login.aspx/BuscarUsuario",
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
                                 </li>
							</ul>
						<footer>
							<ul class="icons">
								<li><a href="#" class="fa-twitter">Twitter</a></li>
								<li><a href="#" class="fa-instagram">Instagram</a></li>
								<li><a href="#" class="fa-facebook">Facebook</a></li>
							</ul>
						</footer>
					</section>
              <div class="fixed-action-btn" style="bottom: 45px; right: 24px;">
                <a href="PagPrincipal.aspx" class="btn-floating btn-large red">
                  <i class="large mdi-editor-mode-edit"></i>
                </a>
                <ul>
                  <li><a href="css-helpers.html" class="btn-floating red" style="transform: scaleY(0.4) scaleX(0.4) translateY(40px); opacity: 0;"><i class="large mdi-communication-live-help"></i></a></li>
                  <li><a href="app-widget.html" class="btn-floating yellow darken-1" style="transform: scaleY(0.4) scaleX(0.4) translateY(40px); opacity: 0;"><i class="large mdi-device-now-widgets"></i></a></li>
                  <li><a href="app-calendar.html" class="btn-floating green" style="transform: scaleY(0.4) scaleX(0.4) translateY(40px); opacity: 0;"><i class="large mdi-editor-insert-invitation"></i></a></li>
                  <li><a href="app-email.html" class="btn-floating blue" style="transform: scaleY(0.4) scaleX(0.4) translateY(40px); opacity: 0;"><i class="large mdi-communication-email"></i></a></li>
                </ul>
            </div>
			</div>
           <script src="../Recursos/css/assets/js/materialize.js"></script>
        <script src="../Recursos/css/assets/js/materialize.min.js"></script>
		<!-- Scripts -->
			<!--[if lte IE 8]><script src="assets/js/respond.min.js"></script><![endif]-->
			<script>
			    if ('addEventListener' in window) {
			        window.addEventListener('load', function () { document.body.className = document.body.className.replace(/\bis-loading\b/, ''); });
			        document.body.className += (navigator.userAgent.match(/(MSIE|rv:11\.0)/) ? ' is-ie' : '');
			    }
			</script>

     
    </div>
        
    </form>
</body>
</html>
