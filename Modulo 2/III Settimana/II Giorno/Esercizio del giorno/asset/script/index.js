const annoCorrente = new Date ().getFullYear()
document.getElementById('anno').innerText= annoCorrente



const  testo= document.getElementById('contenuto')

const premi= function () {
console.log('Hai premuto il pusalnte salva')

const valoreTasto = testo.value
console.log(valoreTasto)

localStorage.setItem('content', valoreTasto) 
}


const elimaLocalsorege= function (){
    console.log('premuto Elimina!')
    localStorage.removeItem('content')
}

const salva= document.getElementById('elimina').addEventListener('click', elimaLocalsorege)

window.onload = function(){
    const  testosalvato= localStorage.getItem('content')
   if(testosalvato)
    testo.value= testosalvato;
}


// Contatore 
 var contatore = sessionStorage.getItem('counter') || 0;
 //Funzione per aggiornare in contatore
 function aggiornaContatore() {
    contatore++; // Incrementa il contatore
    document.getElementById("counter").innerHTML = contatore + " secondi"; // Mostra il tempo trascorso
    sessionStorage.setItem('counter', contatore); // Salva il valore del contatore nella sessionStorage
}

// Avvia il contatore
var intervallo = setInterval(aggiornaContatore, 1000);

