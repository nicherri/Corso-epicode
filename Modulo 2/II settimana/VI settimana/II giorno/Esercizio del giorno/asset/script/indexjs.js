function ottieniAnno() {
    var dataCorrente = new Date();
    var anno = dataCorrente.getFullYear();
    return anno.toString();
}

// Chiamata alla funzione per ottenere l'anno corrente
const annoCorrente = ottieniAnno();
console.log("Anno corrente:", annoCorrente); // Stampa l'anno corrente nella console

// Ottieni il riferimento allo span
var spanAnno = document.getElementById("anno");
console.log("Span:", spanAnno); // Stampa il riferimento allo span nella console

// Aggiorna il contenuto dello span con l'anno corrente
spanAnno.textContent = annoCorrente;
