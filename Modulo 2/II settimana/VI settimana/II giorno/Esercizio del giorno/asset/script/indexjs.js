const ottineiAnno =  function ottieniAnno() {
    var dataCorrente = new Date();
    var anno = dataCorrente.getFullYear();
    return anno.toString();
}

// Ottieni il riferimento allo span
var spanAnno = document.getElementById("anno");
// Aggiorna il contenuto dello span con l'anno corrente
spanAnno.textContent = ottieniAnno();
