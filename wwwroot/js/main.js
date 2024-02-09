"use strict";
//Variabler för sidomeny och menuknapp
let menuBtn = document.getElementById("menuBtn");
let sidebar = document.getElementById('nav-menu');
//Funktion som kontrollerar om knappar eller sidomeny har klickats på eller ej och tar bort klassnamnet active
document.onclick=function(e){
    if(e.target.id !== 'nav-menu' && e.target.id !== 'menuBtn'){
        menuBtn.classList.remove('active');
    sidebar.classList.remove('active');
    }
} //Lägger till active vid klick på knapp eller sidomeny
menuBtn.onclick = function(){
    menuBtn.classList.toggle('active');
    sidebar.classList.toggle('active');
}

