<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index2.aspx.cs" Inherits="COREMEI.index2" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>::LOGIN::</title>
    <link rel="stylesheet" href="css/bootstrap.css" />  
    <script type="text/javascript" src="Js/jquery.min.js"></script>
    <script type="text/javascript" src="Js/bootstrap.min.js"></script>
</head>
<body style="background:#e9e4e4">
    <nav class="navbar navbar-default navbar-fixed-top" role="navigation">
       <div class="container-fluid">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
                <span class="sr-only">Desplegar navegación</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand glyphicon glyphicon-home active" href="Login.aspx"></a>
        </div>
        <div class="collapse navbar-collapse navbar-ex1-collapse">
            <ul class="nav navbar-nav">                            
            </ul>
        </div>
     </div>
    </nav> 
    <br /><br /><br /><br />    
    <form id="form1" runat="server">
        <div class="container">
    	<div class="row">
			<div class="col-md-6 col-md-offset-3">
				<div class="panel panel-login">
					<div class="panel-heading">
						<div class="row">
                            <div class="col-xs-3"></div>
							<div class="col-xs-6">
								<h2>INICIAR SESION:</h2>
							</div>							
						</div>                        
						<hr>
					</div>
					<div class="panel-body">
						<div class="row">
							<div class="col-lg-12">
								<div id="login-form" >
									<div class="form-group">
										<asp:TextBox ID="txtUsuario" runat="server" tabindex="1" CssClass="form-control input-lg" placeholder="Usuario" required></asp:TextBox>
									</div>
									<div class="form-group">
										<asp:TextBox ID="txtPas" runat="server" type="password" tabindex="2" CssClass="form-control input-lg" placeholder="Contraseña" required></asp:TextBox>
									</div>									
									<div class="form-group">
										<div class="row">
                                            <div class="col-md-2"></div>
											<div class="col-sm-6 col-sm-offset-3">
												<asp:Button ID="btnLogin" runat="server" tabindex="4" CssClass="btn btn-primary" Text="INICIAR" />
											</div>
										</div>
									</div>									
								</div>								
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>    
    </form>
</body>
</html>

