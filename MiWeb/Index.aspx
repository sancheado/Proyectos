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
        .mynavbar{background-color:#F5475D !important;color:#ffffff !important;box-shadow: 0px 0px 6px rgba(0, 0, 0, 0.8);}
        .nav-link{color:#ffffff !important;}
        .nav-link:hover{color:black;}
        .sm-menu,.dropdown-item{background-color:#F5475D;color:#ffffff;}

        /* Header */
        .header{background-image: url("imatges/cabecera.png");background-attachment:fixed;background-position:center;background-repeat:no-repeat;background-size:cover;min-height:550px;}
        .ponerImg{position: relative;top: 33px;}
        .redondearImg{width:450px;height:450px;border-radius:225px;border:10px solid #666;margin-top:50px}
        .col-6{color:#FFFFFF;font-weight:700;font-size:25px;text-align:right;}
        .mytext{padding-top:350px;}
        .content{min-height:100vh;}


        /* Footer */
        footer{background-color:#F5475D;color:#ffffff;box-shadow: 0px 0px 6px rgba(0, 0, 0, 0.8);}
        .ftr_social_icon li {display: inline-block;text-align: center;padding: 4px;}
        .ftr_social_icon ul li a {border: 1px solid #fff;border-radius: 50%;color: #fff;display: inline-block;font-size: 17px;height: 40px;line-height: 32px;padding: 4px 8px;width: 40px;transition: .5s;}
        .ftr_social_icon ul li a:hover{background: #33d286;border-color: #33d286;color: #fff;}
        .ftr_btm_area {background: transparent;padding-top: 20px;padding-bottom: 20px;border-top: 1px dotted #888;margin-top: 28px;z-index: 100;position: relative;}
        .copyright_text{margin: 6px 0;}
        .payment_mthd_icon li {display: inline-block;margin-left: 10px;font-size: 30px;color: #fff;}

        .test{display:block;margin: 5px auto;}
        .card-block {
    font-size: 1em;
    position: relative;
    margin: 0;
    padding: 1em;
    border: none;
    border-top: 1px solid rgba(34, 36, 38, .1);
    box-shadow: none;
     
}
.card {
    font-size: 1em;
    overflow: hidden;
    padding: 5;
    border: none;
    border-radius: .28571429rem;
    box-shadow: 0 1px 3px 0 #d4d4d5, 0 0 0 1px #d4d4d5;
    margin-top:20px;
}

.carousel-indicators li {
    border-radius: 12px;
    width: 12px;
    height: 12px;
    background-color: #404040;
}
.carousel-indicators li {
    border-radius: 12px;
    width: 12px;
    height: 12px;
    background-color: #404040;
}
.carousel-indicators .active {
    background-color: white;
    max-width: 12px;
    margin: 0 3px;
    height: 12px;
}
.carousel-control-prev-icon {
 background-image: url("data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' fill='%23fff' viewBox='0 0 8 8'%3E%3Cpath d='M5.25 0l-4 4 4 4 1.5-1.5-2.5-2.5 2.5-2.5-1.5-1.5z'/%3E%3C/svg%3E") !important;
}

.carousel-control-next-icon {
  background-image: url("data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' fill='%23fff' viewBox='0 0 8 8'%3E%3Cpath d='M2.75 0l-1.5 1.5 2.5 2.5-2.5 2.5 1.5 1.5 4-4-4-4z'/%3E%3C/svg%3E") !important;
}
  

.btn {
  margin-top: auto;
}

 .iconos_header{color:#ffffff;font-size:20px;}
 .iconos_header:hover{color:#ffffff;font-size:25px;font-weight:800}
    </style>
</head>
<body style="background-color: #EEEEEE;">
    <div class="header">
        <nav class="navbar navbar-expand-sm navbar-light bg-light fixed-top mynavbar">
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
                        <a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">Mís Servicios
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
                    <a href="https://www.facebook.com/Xanse69" class="iconos_header"><i class="fab fa-facebook"></i></a>
                    <a href="https://twitter.com/Xanse69" class="iconos_header"><i class="fab fa-twitter"></i></a>
                    <a href="https://www.instagram.com/xanse/" class="iconos_header"><i class="fab fa-instagram"></i></a>
                    <a href="https://www.linkedin.com/in/josesanchez1987/" class="iconos_header"><i class="fab fa-linkedin"></i></a>
                </div>
            </div>
        </nav>
        <div class="row ponerImg">
            <div class="col-3">
                aaaa
            </div>
            <div class="col-6 mytext" style="float: right;">
                <span><i class="fas fa-arrow-right" style="color: #F5475D;"></i>Jose Sánchez Mateo</span>
                <br />
                <span><i class="fas fa-user-graduate" style="color: green;"></i>Graduado en Ingeniería Informatica en Tecnologías de la Información</span>
                <br />
                <span><i class="fas fa-briefcase" style="color: #F5475D;"></i>Analista, Desarrollador y Programador Web!</span>
            </div>
            <div class="col-3">
                <img src="imatges/yo.jpg" class="redondearImg" style="margin-right: -15px;" />
            </div>

        </div>
    </div>
    <div class="content">
        <div class="container py-3">
            <div class="title h1 text-center">Horizontal cards - Bootstrap 4</div>
            <!-- Card Start -->
            <div class="card">
                <div class="row ">
                    <div class="col-md-7 px-3">
                        <div class="card-block px-6">
                            <h4 class="card-title">Horizontal Card with Carousel - Bootstrap 4 </h4>
                            <p class="card-text">
                                The Carousel code can be replaced with an img src, no problem. The added CSS brings shadow to the card and some adjustments to the prev/next buttons and the indicators is rounded now. As in Bootstrap 3         
                            </p>
                            <p class="card-text">Made for usage, commonly searched for. Fork, like and use it. Just move the carousel div above the col containing the text for left alignment of images</p>
                            <br>
                            <a href="#" class="mt-auto btn btn-primary">Read More</a>
                        </div>
                    </div>
                </div>
            
        </div>
        <!-- End of card -->        
        </div>
        <div class="container">
            <div class="card float-left">
                <div class="row ">

                    <div class="col-sm-7">
                        <div class="card-block">
                            <!--           <h4 class="card-title">Small card</h4> -->
                            <p>Wetgple text to build your own card.</p>
                            <p>Change around the content for awsomenes</p>
                            <a href="#" class="btn btn-primary btn-sm">Read More</a>
                        </div>
                    </div>

                    <div class="col-sm-5">
                        <img class="d-block w-100" src="https://picsum.photos/150?image=380" alt="" />
                    </div>
                </div>
            </div>            
            <div class="card float-right">
                <div class="row">
                    <div class="col-sm-5">
                        <img class="d-block w-100" src="https://picsum.photos/150?image=641" alt="">
                    </div>
                    <div class="col-sm-7">
                        <div class="card-block">
                            <!--           <h4 class="card-title">Small card</h4> -->
                            <p>Copy paste the HTML and CSS.</p>
                            <p>Change around the content for awsomenes</p>
                            <br>
                            <a href="#" class="btn btn-primary btn-sm float-right">Read More</a>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>


    <footer class="navbar-fixed-bottom">
        <div class="footer">
            <div class="ftr_btm_area">
                <div class="container">
                    <div class="row">
                        <div class="col-sm-4 test">
                            <div class="ftr_social_icon">
                                <p class="copyright_text text-center">© Jose Sánchez Mateo - 2020 ©</p>
                                <ul>
                                    <li><a href="https://www.facebook.com/Xanse69"><i class="fab fa-facebook"></i></a></li>
                                    <li><a href="https://twitter.com/Xanse69"><i class="fab fa-twitter"></i></a></li>
                                    <li><a href="https://www.instagram.com/xanse/"><i class="fab fa-instagram"></i></a></li>
                                    <li><a href="https://www.linkedin.com/in/josesanchez1987/"><i class="fab fa-linkedin"></i></a></li>
                                </ul>
                            </div>
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
<!--
<div class="col-sm-4">
                            <div class="ftr_social_icon">
								<ul>
									<li><a href="https://www.facebook.com/Xanse69"><i class="fab fa-facebook"></i></a></li>
									<li><a href="https://twitter.com/Xanse69"><i class="fab fa-twitter"></i></a></li>
									<li><a href="https://www.instagram.com/xanse/"><i class="fab fa-instagram"></i></a></li>
									<li><a href="https://www.linkedin.com/in/josesanchez1987/"><i class="fab fa-linkedin"></i></a></li>
								</ul>
							</div>									
						</div> -->
