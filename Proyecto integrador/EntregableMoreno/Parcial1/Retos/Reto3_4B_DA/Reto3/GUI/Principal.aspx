
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Reto3.GUI.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title></title>

    <link href="../Recursos/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Recursos/css/datepicker3.css" rel="stylesheet" />
    <link href="../Recursos/css/styles.css" rel="stylesheet" />
    <script src="../Recursos/js/lumino.glyphs.js"></script>
</head>

<body>
    <form id="form1" runat="server">
    	<nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
		<div class="container-fluid">
			<div class="navbar-header">
				<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#sidebar-collapse">
					<span class="sr-only">Toggle navigation</span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
				</button>
				<a class="navbar-brand" href="#"><span>Administración</span> de Alumnos</a>
			</div>
							
		</div><!-- /.container-fluid -->
	</nav>
		
	<div class="col-sm-12 col-lg-12 main">			
		<br />
		<div class="row">
            <div class="col-xs-12 col-md-6 col-lg-3 pull-right">
				<div class="panel panel-blue panel-widget">
					<div class="row no-padding">
						<div class="col-sm-2 col-lg-4 widget-left">
							<svg class="glyph stroked printer"><use xlink:href="#stroked-printer"/></svg>
						</div>
						<div class="col-sm-10 col-lg-8 widget-right">
							<div class="">
                                <asp:Button ID="btnImprimirTodo" runat="server" Text="Imprimir todo" CssClass="btn-default btn-lg" BorderStyle="None" BackColor="White" OnClick="btnImprimirTodo_Click" />
							</div>
						</div>
					</div>
				</div>
			</div>
            <div class="col-xs-12 col-md-6 col-lg-3 pull-right">
				<div class="panel panel-orange panel-widget">
					<div class="row no-padding">
						<div class="col-sm-2 col-lg-4 widget-left">
							<svg class="glyph stroked printer"><use xlink:href="#stroked-printer"/></svg>
						</div>
						<div class="col-sm-10 col-lg-8 widget-right">
							<div class="">
                                <asp:TextBox ID="txtPaginas" runat="server" CssClass="btn-default btn-sm text-center" BackColor="#F2F2F2" BorderStyle="None" ToolTip="Ejemplo: 1 , 2"></asp:TextBox>
                                <asp:Button ID="btnImprimirPaginas" runat="server" Text="Imprimir páginas" CssClass="btn-default btn-sm" BorderStyle="None" BackColor="White" Font-Bold="True" OnClick="btnImprimirPaginas_Click" />
							</div>
						</div>
					</div>
				</div>
			</div>
            <div class="col-xs-12 col-md-6 col-lg-3 pull-right">
				<div class="panel panel-teal panel-widget">
					<div class="row no-padding">
						<div class="col-sm-2 col-lg-4 widget-left">
							<svg class="glyph stroked printer"><use xlink:href="#stroked-printer"/></svg>
						</div>
						<div class="col-sm-10 col-lg-8 widget-right">
							<div class="">
                                <asp:Button ID="btnImprimirActual" runat="server" Text="Imprimir actual" CssClass="btn-default btn-lg" BorderStyle="None" BackColor="White" OnClick="btnImprimirActual_Click" />
							</div>
						</div>
					</div>
				</div>
			</div>
		</div><!--/.row-->
		<div class="row">
			<div class="col-xs-12 col-md-6 col-lg-3">
				<div class="panel panel-blue panel-widget ">
					<div class="row no-padding">
						<div class="col-sm-2 col-lg-4 widget-left">
							<svg class="glyph stroked eye"><use xlink:href="#stroked-eye"/></svg>
						</div>
						<div class="col-sm-10 col-lg-8 widget-right">
                            <asp:DropDownList ID="ddlCantidad" runat="server" CssClass="btn-block" AutoPostBack="True" OnSelectedIndexChanged="ddlCantidad_SelectedIndexChanged">
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>30</asp:ListItem>
                                <asp:ListItem>50</asp:ListItem>
                                <asp:ListItem>100</asp:ListItem>
                                <asp:ListItem>200</asp:ListItem>
                                <asp:ListItem>300</asp:ListItem>
                                <asp:ListItem>400</asp:ListItem>
                                <asp:ListItem>500</asp:ListItem>
                                <asp:ListItem>600</asp:ListItem>
                                <asp:ListItem>700</asp:ListItem>
                                <asp:ListItem>800</asp:ListItem>
                                <asp:ListItem>900</asp:ListItem>
                                <asp:ListItem>1000</asp:ListItem>
                                <asp:ListItem>1100</asp:ListItem>
                                <asp:ListItem>1200</asp:ListItem>
                                <asp:ListItem>1300</asp:ListItem>
                                <asp:ListItem>1400</asp:ListItem>
                                <asp:ListItem>1500</asp:ListItem>
                            </asp:DropDownList>
							<div class="text-muted"><center>Ver cantidad</center></div>
						</div>
					</div>
				</div>
			</div>
			<div class="col-xs-12 col-md-6 col-lg-3">
				<div class="panel panel-orange panel-widget">
					<div class="row no-padding">
						<div class="col-sm-2 col-lg-4 widget-left">
							<svg class="glyph stroked external hard drive"><use xlink:href="#stroked-external-hard-drive"/></svg>
						</div>
						<div class="col-sm-10 col-lg-8 widget-right">
							<div class="">
                                <asp:Button ID="btnXML" runat="server" Text="Guardar XML" CssClass="btn-default btn-lg" BorderStyle="None" BackColor="White" OnClick="btnXML_Click" />
							</div>
						</div>
					</div>
				</div>
			</div>
            <div class="col-xs-12 col-md-6 col-lg-3">
				<div class="panel panel-teal panel-widget">
					<div class="row no-padding">
						<div class="col-sm-2 col-lg-4 widget-left">
							<svg class="glyph stroked external hard drive"><use xlink:href="#stroked-external-hard-drive"/></svg>
						</div>
						<div class="col-sm-10 col-lg-8 widget-right">
							<div class="">
                                <asp:Button ID="btnJSON" runat="server" Text="Guardar JSON" CssClass="btn-default btn-lg" BorderStyle="None" BackColor="White" OnClick="btnJSON_Click" />
							</div>
						</div>
					</div>
				</div>
			</div>
		</div><!--/.row-->
		
		<div class="row">
			<div class="col-lg-12">
				<div class="panel panel-default">
					<div class="panel-heading">Listas</div>
					<div class="panel-body">
						<div class="canvas-wrapper">
                            <center>
							<asp:GridView ID="gvDatos" CssClass="table-bordered table" runat="server" AllowPaging="True" OnPageIndexChanging="gvDatos_PageIndexChanging">
                                <PagerStyle BorderStyle="Dotted" CssClass="" HorizontalAlign="Center" Font-Size="Large" />
                                </asp:GridView>
                                <h3>Paginación</h3>
                                </center>
						</div>
					</div>
				</div>
			</div>
		</div><!--/.row-->
		
	</div>	<!--/.main-->


<script src="../Recursos/js/jquery-1.11.1.min.js"></script>
        <script src="../Recursos/js/bootstrap.min.js"></script>
        <script src="../Recursos/js/chart.min.js"></script>
        <script src="../Recursos/js/chart-data.js"></script>
        <script src="../Recursos/js/easypiechart.js"></script>
        <script src="../Recursos/js/easypiechart-data.js"></script>
        <script src="../Recursos/js/bootstrap-datepicker.js"></script>


        <script>
		$('#calendar').datepicker({
		});

		!function ($) {
		    $(document).on("click","ul.nav li.parent > a > span.icon", function(){          
		        $(this).find('em:first').toggleClass("glyphicon-minus");      
		    }); 
		    $(".sidebar span.icon").find('em:first').addClass("glyphicon-plus");
		}(window.jQuery);

		$(window).on('resize', function () {
		  if ($(window).width() > 768) $('#sidebar-collapse').collapse('show')
		})
		$(window).on('resize', function () {
		  if ($(window).width() <= 767) $('#sidebar-collapse').collapse('hide')
		})
	</script>

    </form>
</body>
</html>
