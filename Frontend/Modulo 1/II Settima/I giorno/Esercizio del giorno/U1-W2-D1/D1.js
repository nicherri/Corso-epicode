/*
REGOLE
- Tutte le risposte devono essere scritte in JavaScript
- Puoi usare Google / StackOverflow ma solo quanto ritieni di aver bisogno di qualcosa che non è stato spiegato a lezione
- Puoi testare il tuo codice in un file separato, o de-commentando un esercizio alla volta
- Per visualizzare l'output, lancia il file HTML a cui è collegato e apri la console dagli strumenti di sviluppo del browser. 
- Utilizza dei console.log() per testare le tue variabili e/o i risultati delle espressioni che stai creando.
*/
/* ++++++++++++++++++++++++ESERCIZIO 1++++++++++++++++++++++++++++++++++++++++++++++++++++
 Elenca e descrivi i principali datatype in JavaScript. Prova a spiegarli come se volessi farli comprendere a un bambino.

I datatype (tipi di dati) in JavaScript siano come giocattoli diversi nel tuo armadietto dei giochi. 
Ogni tipo di giocattolo ha un suo scopo e un modo diverso di giocarci. Ci sono 5 tipi di di dati primitivi e sono:

1. Stringhe (Strings): Le stringhe sono come i fili per fare i braccialetti colorati. Possono contenere parole, 
  frasi o lettere. Ad esempio, "cane", "gatto", o "ciao mondo" sono tutte stringhe

2. Numeri (Numbers): I numeri sono come i mattoncini LEGO che usi per costruire una torre. Possono essere numeri interi 
  come 1, 2, 3 o numeri decimali come 3.14. Puoi usarli per fare calcoli o per contare.

3. Booleani (Booleans): I booleani sono come dei cartelli con scritto "sì" o "no", "vero" o "falso". 
  Sono usati per esprimere concetti come vero o falso, acceso o spento. Ad esempio, se chiedi 
  "Hai fame?", la risposta potrebbe essere vero (sì) o falso (no).

4. Null: significa che non c'è nulla, come un armadietto vuoto.

5. Undefined: significa che qualcosa esiste, ma non ha ancora un valore definito, 
  come un regalo che devi ancora ricevere.

  ----------- Infine fli altri tipi di dati sono complessi e sono gli Array, funzioni e oggetti
*/



/*++++++++++++++++++++++++++ ESERCIZIO 2++++++++++++++++++++++++++++++++++++++
 Crea una variable chiamata "myName" e assegna ad essa il tuo nome, sotto forma di stringa.
 */       
 var myName = "Nicola"


/*++++++++++++++++++++++++++ ESERCIZIO 3+++++++++++++++++++++++++++++++++++++++++++
 Scrivi il codice necessario ad effettuare un addizione (una somma) dei numeri 12 e 20.
 */
var risultato = 12+20;7
console.log(risultato);


/*+++++++++++++++++++++++++++++ ESERCIZIO 4++++++++++++++++++++++++++
 Crea una variable di nome "x" e assegna ad essa il numero 12.
*/
 var x = 12;
 console.log(x)



/*+++++++++++++++++++++++++++++ ESERCIZIO 5+++++++++++++++++++++++++
  Riassegna un nuovo valore alla variabile "myName" già esistente: il tuo cognome.
  Dimostra l'impossibilità di riassegnare un valore ad una variabile dichiarata con il costrutto const.
*/
var myName = "Schirripa"

/*+++++++++++++++++++++++++++++++++++++ ESERCIZIO 6++++++++++++++++++++
 Esegui una sottrazione tra i numeri 4 e la variable "x" appena dichiarata (che contiene il numero 12).
*/
x = x-4;
console.log(x)

/* ++++++++++++++++++++++++++ESERCIZIO 7+++++++++++++++++++++++
 Crea due variabili: "name1" e "name2". Assegna a name1 la stringa "john", e assegna a name2 la stringa "John" (con la J maiuscola!).
 Verifica che name1 sia diversa da name2 (suggerimento: è la stessa cosa di verificare che la loro uguaglianza sia falsa).
 EXTRA: verifica che la loro uguaglianza diventi true se entrambe vengono trasformate in lowercase (senza cambiare il valore di name2!).
*/
var name1 = "john";
var name2 = "John";
var utenteUguale = name1 !== name2 ;
  
(name1 === name2) ? console.log("sono Uguali"): console.log(" Sono diversi"); 

name1.toLowerCase === name2.toLowerCase? console.log("sono uguali") : console. log (" sono diversi");