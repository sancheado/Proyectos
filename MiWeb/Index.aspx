<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Index.aspx.vb" Inherits="MyWebSite.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript">
        function LlançaAvis(Text) {
            bootbox.alert({ title: "TOWERPLANE TESTEO JOSE", message: Text });
        }
    </script>
    <title>Bienvenidos al sitio Web de Sánchez</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.11.2/css/all.css">
    <link href="https://fonts.googleapis.com/css?family=Raleway:400,500,500i,700,800i" rel="stylesheet">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <style type="text/css">
        body{margin:0;padding:0;box-sizing:border-box;}
        .row{margin-left:0 !important;margin-right:0 !important;}
        
        /* NavBar */
        .social-part .fa{padding-right:20px;}
        ul li a{margin-right: 20px;}
        .social-part i{padding-right:25px}

        /* Header */
        .header{background-image: url("imatges/cabecera.png");background-attachment:fixed;background-position:center;background-repeat:no-repeat;background-size:cover;min-height:550px;}
        .ponerImg{position: relative;top: 33px;}
        .redondearImg{width:450px;height:450px;border-radius:225px;border:10px solid #666;margin-top:50px}
        .col-6{color:#FFFFFF;font-weight:700;font-size:25px;text-align:right;}
        .mytext{padding-top:350px;}
        .content{min-height:100vh;}


        /* Footer */
        footer{background-color:#1E1E1E;color:#ffffff;}
        .ftr_social_icon li {display: inline-block;text-align: center;padding: 4px;}
        .ftr_social_icon ul li a {border: 1px solid #fff;border-radius: 50%;color: #fff;display: inline-block;font-size: 17px;height: 40px;line-height: 32px;padding: 4px 8px;width: 40px;transition: .5s;}
        .ftr_social_icon ul li a:hover{background: #33d286;border-color: #33d286;color: #fff;}
        .ftr_btm_area {background: transparent;padding-top: 20px;padding-bottom: 20px;border-top: 1px dotted #888;margin-top: 28px;z-index: 100;position: relative;}
        .copyright_text{margin: 6px 0;}
        .payment_mthd_icon li {display: inline-block;margin-left: 10px;font-size: 30px;color: #fff;}
        
    </style>
</head>
<body style="background-color:#ABABAB;">
    <div class="header">
        <nav class="navbar navbar-expand-sm navbar-light bg-light fixed-top">
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarTogglerDemo03" aria-controls="navbarTogglerDemo03" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarTogglerDemo03">
          <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
            <li class="nav-item">
              <a class="nav-link" href="#">Inicio <span class="sr-only">(current)</span></a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="#">Sobre Mí</a>
            </li>
            <li class="nav-item dropdown dmenu">
            <a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">
              Mís Servicios
            </a>
            <div class="dropdown-menu sm-menu">
              <a class="dropdown-item" href="#">service2</a>
              <a class="dropdown-item" href="#">service 2</a>
              <a class="dropdown-item" href="#">service 3</a>
            </div>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">Contactame</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">Call</a>
          </li>
          </ul>
          <div class="social-part">
            <i class="fab fa-facebook"></i>
            <i class="fab fa-twitter"></i>
            <i class="fab fa-instagram" aria-hidden="true"></i>
          </div>
        </div>
      </nav>
        <div class="row ponerImg">
            <div class="col-3">
                aaaa
            </div>
            <div class="col-6 mytext" style="float:right;">
                <span><i class="fas fa-arrow-right" style="color:red;"></i> Jose Sánchez Mateo</span>
                <br />
                <span><i class="fas fa-user-graduate" style="color:green;"></i> Graduado en Ingeniería Informatica en Tecnologías de la Información</span>
                <br />
                <span><i class="fas fa-briefcase" style="color:red;"></i> Analista, Desarrollador y Programador Web!</span>
            </div>
            <div class="col-3">
                <img src="imatges/yo.jpg" class="redondearImg" style="margin-right: -15px;" />
            </div>
                        
        </div>
    </div>
    <div class="content">Holiii</div>
    <footer class="navbar-fixed-bottom">
        <div class="footer">
            <div class="ftr_btm_area">
				<div class="container">
					<div class="row">
						<div class="col-sm-4">
							<div class="ftr_social_icon">
								<ul>
									<li><a href="https://www.facebook.com/Xanse69"><i class="fab fa-facebook"></i></a></li>
									<li><a href="https://twitter.com/Xanse69"><i class="fab fa-twitter"></i></a></li>
									<li><a href="https://www.instagram.com/xanse/"><i class="fab fa-instagram"></i></a></li>
									<li><a href="https://www.linkedin.com/in/josesanchez1987/"><i class="fab fa-linkedin"></i></a></li>
								</ul>
							</div>
						</div>
						<div class="col-sm-4">
							<p class="copyright_text text-center">© Jose Sánchez Mateo - 2020 ©</p>
						</div>						
						<div class="col-sm-4">
                            <div class="ftr_social_icon">
								<ul>
									<li><a href="https://www.facebook.com/Xanse69"><i class="fab fa-facebook"></i></a></li>
									<li><a href="https://twitter.com/Xanse69"><i class="fab fa-twitter"></i></a></li>
									<li><a href="https://www.instagram.com/xanse/"><i class="fab fa-instagram"></i></a></li>
									<li><a href="https://www.linkedin.com/in/josesanchez1987/"><i class="fab fa-linkedin"></i></a></li>
								</ul>
							</div>
							<div class="payment_mthd_icon text-right">
								<ul>
									
						</div>
					</div>
				</div>
			</div>
        </div>
    </footer>
    
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('.navbar-light .dmenu').hover(function () {
                $(this).find('.sm-menu').first().stop(true, true).slideDown(150);
            }, function () {
                $(this).find('.sm-menu').first().stop(true, true).slideUp(105)
            });
        });
    </script>
</body>
</html>
