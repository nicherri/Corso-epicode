const myNav = document.querySelector('header');
const button = document.getElementById('getStarted');

window.onscroll = function () { 
    if (document.documentElement.scrollTop > 320 ) {
        myNav.classList.add("scrolled");
        button.style.backgroundColor = "green";
    } 
    else {
        myNav.classList.remove("scrolled");
        button.style.backgroundColor = "#191919";
    }
};

 // Funzione per impostare l'opacità di un elemento SVG
 function setOpacity(element, opacity) {
    element.setAttribute('opacity', opacity);
}

