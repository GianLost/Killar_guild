// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function ValidarForm() {

    var SenhaPub = formuser.SenhaPub.value;
    var CheckSenhaPub = formuser.CheckSenhaPub.value;
    var Nome = formuser.Nome.value;
    var DataNasc = formuser.DataNasc.value;
    var WhatsPub = formuser.WhatsPub.value;
    var EmailPub = formuser.EmailPub.value;
    var NickWr = formuser.NickWr.value;
    var LoginNamePub = formuser.LoginNamePub.value;
    var Elo = formuser.Elo.value;
    var Lane = formuser.Lane.value;
    var Tipo = formuser.Tipo.value;

    if (Nome == "") {
        alert("O campo Nome é obrigatório");
        formuser.Nome.focus();
        return (false);
    }

    if (DataNasc == "") {
        alert("O campo Data é obrigatório");
        formuser.DataNasc.focus();
        return (false);
    }

    if (WhatsPub == "") {
        alert("O campo Telefone é obrigatório");
        formuser.WhatsPub.focus();
        return (false);
    }

    if (EmailPub == "") {
        alert("O campo Email é obrigatório");
        formuser.EmailPub.focus();
        return (false);
    }

    if (NickWr == "") {
        alert("O campo Nick Wr é obrigatório");
        formuser.NickWr.focus();
        return (false);
    }

    if (LoginNamePub == "") {
        alert("O campo Nick Name é obrigatório");
        formuser.LoginNamePub.focus();
        return (false);
    }

    if (SenhaPub == "" || SenhaPub.length <= 5) {
        alert("Preencha o campo de senha com no minimo 6 caracteres");
        formuser.SenhaPub.focus();
        return (false);
    }

    if (CheckSenhaPub == "") {
        alert("Preencha o campo de senha com no minimo 6 caracteres");
        formuser.CheckSenhaPub.focus();
        return (false);
    }

    if (SenhaPub != CheckSenhaPub || CheckSenhaPub.length <= 5) {
        alert("As senhas são diferentes");
        formuser.SenhaPub.focus();
        return (false);
    }

    if (Elo == "") {
        alert("O campo Elo é obrigatório");
        formuser.Elo.focus();
        return (false);
    }

    if (Lane == "") {
        alert("O campo Lane é obrigatório");
        formuser.Lane.focus();
        return (false);
    }
    if (Tipo == "") {
        alert("O campo Tipo é obrigatório");
        formuser.Tipo.focus();
        return (false);
    } else {

        alert("Cadastro realizado com Sucesso!")

    }
}

function ValidarFormEdit() {
    if (Nome == "" & DataNasc == "" & WhatsPub == "" & EmailPub == "" & NickWr == "" & LoginNamePub == "" & SenhaPub == "" & CheckSenhaPub == "" & Elo == "" & Lane == "" & Tipo == "") {
        alert("Um ou mais campos obrigatórios não foram preenchidos")
        return (false);
    } else {
        alert("Alterações salvas com sucesso!")
    }
}

// java script carrossel

var slideIndex = 1;
var slideIndex2 = 0;

showSlidesAutomatic();

function plusSlides(n) {
    showSlides(slideIndex += n);
}

function currentSlide(n) {
    showSlides(slideIndex = n);
}

function showSlides(n) {

    var i;
    var slides = document.getElementsByClassName("myslides");
    var dots = document.getElementsByClassName("dot");

    if (n > slides.length) { slideIndex = 1 }

    if (n < 1) { slideIndex = slides.length }

    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }

    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "")
    }

    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";

}

function showSlidesAutomatic() {

    var i;
    var slides = document.getElementsByClassName("myslides");
    var dots = document.getElementsByClassName("dot");

    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    slideIndex2++;

    if (slideIndex2 > slides.length) {
        slideIndex2 = 1
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "")
    }

    slides[slideIndex2 - 1].style.display = "block";
    dots[slideIndex2 - 1].className += " active";

    setTimeout(showSlidesAutomatic, 3000)

}