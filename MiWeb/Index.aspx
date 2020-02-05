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
    <link href="https://fonts.googleapis.com/css?family=Cambay&display=swap" rel="stylesheet">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <script type="text/javascript">
        var TxtType = function (el, toRotate, period) {
            this.toRotate = toRotate;
            this.el = el;
            this.loopNum = 0;
            this.period = parseInt(period, 10) || 2000;
            this.txt = '';
            this.tick();
            this.isDeleting = false;
        };

        TxtType.prototype.tick = function () {
            var i = this.loopNum % this.toRotate.length;
            var fullTxt = this.toRotate[i];

            if (this.isDeleting) {
                this.txt = fullTxt.substring(0, this.txt.length - 1);
            } else {
                this.txt = fullTxt.substring(0, this.txt.length + 1);
            }

            this.el.innerHTML = '<span class="wrap">' + this.txt + '</span>';

            var that = this;
            var delta = 200 - Math.random() * 100;

            if (this.isDeleting) { delta /= 2; }

            if (!this.isDeleting && this.txt === fullTxt) {
                delta = this.period;
                this.isDeleting = true;
            } else if (this.isDeleting && this.txt === '') {
                this.isDeleting = false;
                this.loopNum++;
                delta = 500;
            }

            setTimeout(function () {
                that.tick();
            }, delta);
        };

        window.onload = function () {
            var elements = document.getElementsByClassName('typewrite');
            for (var i = 0; i < elements.length; i++) {
                var toRotate = elements[i].getAttribute('data-type');
                var period = elements[i].getAttribute('data-period');
                if (toRotate) {
                    new TxtType(elements[i], JSON.parse(toRotate), period);
                }
            }
            // INJECT CSS
            var css = document.createElement("style");
            css.type = "text/css";
            css.innerHTML = ".typewrite > .wrap { border-right: 0.08em solid #fff;}";
            document.body.appendChild(css);
        };
    </script>
    <style type="text/css">
        body{margin:0;padding:0;box-sizing:border-box;}
        .row{margin-left:0 !important;margin-right:0 !important;}
        
        /* NavBar */
        .social-part .fa{padding-right:20px;}
        ul li a{margin-right: 20px;}
        .social-part i{padding-right:25px}
        .mynavbar{background-color:#DB230C !important;color:#ffffff !important;box-shadow: 0px 0px 6px rgba(0, 0, 0, 0.8);}
        .nav-link{color:#ffffff !important;}
        .nav-link:hover{color:black;}
        .sm-menu,.dropdown-item{background-color:#DB230C;color:#ffffff;}

        /* Header */
        .header{Position:relative;background-image: url("imatges/Yo_Madrid.jpg");height:90vh;background-attachment:fixed;background-position:center;background-repeat:no-repeat;background-size:cover;}
        .textoAnimado{width: 80%;position: absolute;top: 35%;left: 40%;}
        .textoAnimado a{font-family: 'Cambay', sans-serif;padding:20px; color:#ffffff;}
        .textoAnimado a:hover{text-decoration:none;}

        /* Content */
        .content{background-color: #ffffff;border: .4px solid black;margin-top: 100px;box-shadow: 1px 2px 6px 2px rgba(0, 0, 0, 0.1);}
        .page-heading{position: relative;margin-bottom: 20px;margin-top:20px;}
        .page-heading h1 {font-size: 24px;margin-bottom: 5px;}
        .page-heading p {font-size: 14px;color: #777;}
        .skill-block {overflow: hidden;padding: 5px 15px 15px;text-align: center;box-shadow:1px 2px 6px 2px rgba(0, 0, 0, 0.1);margin: 15px auto;}
        .sk-border h2 {color: #777;display: inline-block;font-size: 48px;font-weight: 900;height: 200px;width: 180px;}
        .sk-border{text-align: center;line-height: 100px;position:relative;z-index:0;margin: 70px auto;}
        .sk-border,.sk-border:before,.sk-border:after{border-style: solid;border-color: #F5475D;border-width: 7px;border-top: none;border-bottom: none;height: 105px;width: 183px;}
        .sk-border:after,.sk-border:before{content: "";position: absolute;top:0;left: -7px;z-index: -1;}
        .sk-border:before{-webkit-transform: rotate(60deg);-moz-transform: rotate(60deg);-ms-transform: rotate(60deg);-o-transform: rotate(60deg);transform: rotate(60deg);}
        .sk-border:after{-webkit-transform: rotate(-60deg);-moz-transform: rotate(-60deg);-ms-transform: rotate(-60deg);-o-transform: rotate(-60deg);transform: rotate(-60deg);}
        .sk-text h4 {font-size: 18px;text-transform: uppercase;margin-bottom: 10px;}
        h4 img{width: 20%;margin-top: -5px;}
        /* 2º Content */
        .our-skills h1{padding:25px;font-family: 'Cambay', sans-serif;font-size: 24px;margin-bottom: 5px;font-weight: 600;line-height: 1.2;}
        .our-skills .progress-bar {line-height: 36px;font-size: 15px;font-weight: bold;text-align: left;text-indent: 10px;}
        .progress-bar-success {background-color: #5cb85c;}
        .our-skills .progress-bar {line-height: 36px;font-size: 15px;font-weight: bold;text-align: left;text-indent: 10px;}
        .progress-bar-danger {background-color: #d9534f;}
        .our-skills .progress-bar {line-height: 36px;font-size: 15px;font-weight: bold;text-align: left;text-indent: 10px;}
        .progress-bar-warning {background-color: #f0ad4e; }
        .our-skills .progress-bar {line-height: 36px;font-size: 15px;font-weight: bold;text-align: left;text-indent: 10px;}
        .progress-bar-info {background-color: #5bc0de;}
        .our-skills .progress {height: 36px;margin: 15px;padding: 1px;}
        .btnHabilidades{margin-bottom:25px;}

        /* Contacto */
        .contacto{background-color:#ffffff;color:Black;border: .4px solid black;box-shadow: 1px 2px 6px 2px rgba(0, 0, 0, 0.1);margin-top:100px}
        .contacto h2{padding:25px;font-family: 'Cambay', sans-serif;font-size: 24px;margin-bottom: 5px;font-weight: 600;line-height: 1.2;text-align:center;text-align: center;display: block;margin: 0 auto;}
        form{display:block;width:50%;margin: 10px auto;}
        
        /* Footer */
        footer{background-color:#DB230C;color:#ffffff;box-shadow: 0px 0px 6px rgba(0, 0, 0, 0.8);}
        .ftr_social_icon li {display: inline-block;text-align: center;padding: 4px;}
        .ftr_social_icon ul li a {border: 1px solid #fff;border-radius: 50%;color: #fff;display: inline-block;font-size: 17px;height: 40px;line-height: 32px;padding: 4px 8px;width: 40px;transition: .5s;}
        .ftr_social_icon ul li a:hover{background: #33d286;border-color: #33d286;color: #fff;}
        .ftr_btm_area {background: transparent;padding-top: 20px;padding-bottom: 20px;border-top: 1px dotted #888;margin-top: 28px;z-index: 100;position: relative;}
        .copyright_text{margin: 6px 0;}
        .payment_mthd_icon li {display: inline-block;margin-left: 10px;font-size: 30px;color: #fff;}
        .test{display:block;margin: 5px auto;}
        .card-block {font-size: 1em;position: relative;margin: 0;padding: 1em;border: none;border-top: 1px solid rgba(34, 36, 38, .1);box-shadow: none;}
        .card {font-size: 1em;overflow: hidden;padding: 5px; border: none;border-radius: .28571429rem;box-shadow: 0 1px 3px 0 #d4d4d5, 0 0 0 1px #d4d4d5;margin-top:20px;}
        .carousel-indicators li {border-radius: 12px;width: 12px;height: 12px;background-color: #404040;}
        .carousel-indicators li {border-radius: 12px;width: 12px;height: 12px;background-color: #404040;}
        .carousel-indicators .active {background-color: white;max-width: 12px;margin: 0 3px;height: 12px;}
        .carousel-control-prev-icon {background-image: url("data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' fill='%23fff' viewBox='0 0 8 8'%3E%3Cpath d='M5.25 0l-4 4 4 4 1.5-1.5-2.5-2.5 2.5-2.5-1.5-1.5z'/%3E%3C/svg%3E") !important;}
        .carousel-control-next-icon {background-image: url("data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' fill='%23fff' viewBox='0 0 8 8'%3E%3Cpath d='M2.75 0l-1.5 1.5 2.5 2.5-2.5 2.5 1.5 1.5 4-4-4-4z'/%3E%3C/svg%3E") !important;}
        .btn {margin-top: auto;}
        .iconos_header{color:#ffffff;font-size:20px;}
        .iconos_header:hover{color:#ffffff;font-size:25px;font-weight:800}

        @media screen and (max-width: 1200px) {
            .wrap{font-size:18px;}
            .col-sm-6 {-ms-flex: 0 0 50%;flex: 0 0 50%;max-width: 50%;}
        }
        @media screen and (max-width: 600px) {
            .wrap{font-size:18px;}
            .col-sm-6 {-ms-flex: 0 0 100%;flex: 0 0 100%;max-width: 100%;}
            .content {width:95%;}
        }
    </style>
</head>
<body style="background-color: #EEEEEE;">
    <div class="header">
        <nav class="navbar mr-auto navbar-expand-sm navbar-light bg-light fixed-top mynavbar">
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarTogglerDemo03" aria-controls="navbarTogglerDemo03" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarTogglerDemo03">
                <ul class="navbar-nav mr-auto mt-2 mt-lg-0 justify-content-end">
                    <li class="nav-item">
                        <a class="nav-link disabled" href="#">Inicio <span class="sr-only">(current)</span></a>
                    </li>
                    <li class="nav-item dropdown dmenu">
                        <a class="nav-link dropdown-toggle" href="#" id="navbardropHabilitats" data-toggle="dropdown">Sobre Mí
                        </a>
                        <div class="dropdown-menu sm-menu">
                            <a class="dropdown-item" href="#Habilidades">Habilidades</a>
                            <a class="dropdown-item" href="#Habilidades2">Habilidades 2</a>
                        </div>

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
                        <a class="nav-link" href="#Formulario">Contactame</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Call</a>
                    </li>
                </ul>
            </div>
        </nav>
        <div class="container">
            <div class="textoAnimado">
                <h1>
                    <a href="#" class="typewrite" data-period="2000" data-type='[ "Estás en la Web de <b>Jose Sánchez</b>.", "Analista, Desarrollador y Programador.", "Cuentamé tu problema. :)"]'>
                        <span class="wrap"></span>
                    </a>
                </h1>
            </div>
        </div>
    </div>
    <!-- Mis Hablidades 1/2 -->
    <div id="Habilidades" class="container content">
        <div class="row">
            <div class="col-sm-12">
                <div class="page-heading text-center">
                    <h1>Mis Habilidades 1/2</h1>
                    <p>Aquí os enseño las habilidades que tengo en cuanto al <b><u>Diseño WEB</u></b>
                        <br />
                        Dichas habilidades las he ido adquiriendo a lo largo de mi vida mediante estudios ó distintos trabajos que he ido realizando.</p>
                </div>
                <div class="row">
                    <div class="col-xs-12 col-sm-6 col-md-3">
                        <div class="skill-block">
                            <div class="sk-border">
                                <h2>98%</h2>
                            </div>
                            <div class="sk-text">
                                <h4><img src="imatges/HTML5_Logo.png" />HTML/CSS</h4>
                                <p>Años de formación y aprendizaje tanto en diferentes <b>Empresas</b> como por propia motivación. Varios proyectos echos por cuenta propia, tanto para amigos como personales para mí.</p>
                            </div>
                        </div>
                    </div>
                    <div class="col-xs-12 col-sm-6 col-md-3">
                        <div class="skill-block">
                            <div class="sk-border">
                                <h2>80%</h2>
                            </div>
                            <div class="sk-text">
                                <h4><img src="imatges/JS_Logo.png" />Javascript</h4>
                                <p>Aunque es cierto que lo considero un lenguaje <b>"más follonero"</b> también es cierto que es el mejor lenguaje para la validación de los campos de un Formulario.Por ello es <b>IMPRESCINDIBLE</b>.</p>
                            </div>
                        </div>
                    </div>
                    <div class="col-xs-12 col-sm-6 col-md-3">
                        <div class="skill-block">
                            <div class="sk-border">
                                <h2>75%</h2>
                            </div>

                            <div class="sk-text">
                                <h4><img src="imatges/ASP_Logo.png" />ASP.NET</h4>
                                <p>Un año de experiencia en <b>TOWERPLANE ADVANCED PROJECTS</b> con la creación de formularios <b>RESPONSIVES</b> y también creando el <b>BackOffice</b> para la gestión de Eventos.</p>
                            </div>
                        </div>
                    </div>
                    <div class="col-xs-12 col-sm-6 col-md-3">
                        <div class="skill-block">
                            <div class="sk-border">
                                <h2>92%</h2>
                            </div>

                            <div class="sk-text">
                                <h4><img src="imatges/logo_php.png" />PHP</h4>
                                <p>Dos años de experiencia en distintas asignaturas de la <b>UNIVERSIDAD</b> Sin contar diversos cursos/talleres que yo he ido realizando por cuenta propia y diversos proyectos.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <!-- Mis Hablidades 2/2 -->
    <div id="Habilidades2" class="container content">
       <section class="our-skills">
            <div class="container">
                <h1 class="text-center">Mis Habilidades 2/2</h1>
                <div class="row">                    
                    <!-- Start Progress Skills -->                    
                    <div class="col-md-5">
                        <div class="skills-progress">
                            <div class="progress">
                                <div class="progress-bar progress-bar-success" role="progressbar" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100" style="width:85%">
                                    Trabajo en Equipo
                                </div>
                            </div>
                            <div class="progress">
                                <div class="progress-bar progress-bar-danger" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width:95%">
                                    Capacidad de Comunicación
                                </div>
                            </div>
                            <div class="progress">
                                <div class="progress-bar progress-bar-warning" role="progressbar" aria-valuenow="70" aria-valuemin="0" aria-valuemax="100" style="width:84%">
                                    Apasionado del Trabajo
                                </div>
                            </div>
                            <div class="progress">
                                <div class="progress-bar progress-bar-info" role="progressbar" aria-valuenow="95" aria-valuemin="0" aria-valuemax="100" style="width:95%">
                                    Capacidad toma de Decisiones
                                </div>
                            </div>
                        </div>
                    </div>                    
                    <!-- End Progress Skills -->                    
                    <!-- Start Team Info -->                    
                    <div class="col-md-6 col-md-offset-1">
                        <div class="skills-info">
                            <h3>Más sobre mí</h3>
                            <p class="lead">Siempre he sido un amante/apasionado de las nuevas tecnologías y por ello mi historia con la programación y sus lenguajes comenzo desde bien pequeñito, cuando comenze con los ordenadores, creo recordar que erá con WINDOWS 95 y para entrar al escritorio necesitabas primero tener algun conocimiento de MS-DOS</p>
                            <br />
                            <button type="button" class="btn btn-primary btnHabilidades">Habla conmigo sin compromiso!</button>
                        </div>
                    </div>                    
                    <!-- End Team Info -->                    
                </div>
            </div>
        </section>
    </div>
    <br />
    <!-- Contacto -->
    <div id="Formulario" class="container contacto">
        <div class="row">
            <h2>
                Formulario de Contacto
            </h2>
        </div>
        <div class="row">
            <form>
                <div class="card-body p-3">
                    <!--Body-->
                    <div class="form-group">
                        <div class="input-group mb-2">
                            <div class="input-group-prepend">
                                <div class="input-group-text"><i class="fa fa-user text-info"></i></div>
                            </div>
                            <input type="text" class="form-control" id="nombre" name="nombre" placeholder="Nombre y Apellido" required>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="input-group mb-2">
                            <div class="input-group-prepend">
                                <div class="input-group-text"><i class="fa fa-envelope text-info"></i></div>
                            </div>
                            <input type="email" class="form-control" id="nombre" name="email" placeholder="ejemplo@gmail.com" required>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="input-group mb-2">
                            <div class="input-group-prepend">
                                <div class="input-group-text"><i class="fa fa-comment text-info"></i></div>
                            </div>
                            <textarea class="form-control" placeholder="Envianos tu Mensaje" required></textarea>
                        </div>
                    </div>
                    <div class="text-center">
                        <input type="submit" value="Enviar" class="btn btn-info btn-block rounded-0 py-2">
                    </div>
                </div>
            </form>
        </div>
    </div>
    <!-- Footer -->
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
    <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    <script src='https://cdnjs.cloudflare.com/ajax/libs/gsap/1.15.0/TweenMax.min.js'></script>
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
