/*++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ESERCIZIO 1
 Scrivi un algoritmo per trovare il più grande tra due numeri interi.
*/

/* SCRIVI QUI LA TUA RISPOSTA */
let num1=70;
let num2=56;

if (num1>num2){
  console.log(" num1 è il numero più grande")
}
 else {
  console.log("num2 è il numero più grande")
 }


/*++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ESERCIZIO 2
  Scrivi un algoritmo che mostri "not equal" in console se un numero intero fornito è diverso da 5.
*/

/* SCRIVI QUI LA TUA RISPOSTA */

let numero1= 8;
let numero5= 5;

if (numero1=== numero5){
  console.log ( "numero1 e numero2 sono uguali ")
}

else { console.log ( "not equal" )}

/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ESERCIZIO 3
  Scrivi un algoritmo che mostri "divisibile per 5" in console se un numero fornito è perfettamente divisibile per 5 (suggerimento: usa l'operatore modulo)
*/

/* SCRIVI QUI LA TUA RISPOSTA */

let number1= 100;

if  (number1%5 == 0) {
      console. log ("divisibile per 5");
  }
  else {
     console.log ("non è divisibile per 5")}
     



/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ESERCIZIO 4
  Scrivi un algoritmo per verificare che, dati due numeri interi, il valore di uno di essi sia 8 oppure se la loro addizione/sottrazione sia uguale a 8.
*/

/* SCRIVI QUI LA TUA RISPOSTA */
let numb1=8;
let numb2= 5;

if ((numb1==8) || (numb2==8) (numb1+numb2==8) || (numb1-numb2==8))
{
  console.log ("pippo")
}

/*++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ESERCIZIO 5
  Stai lavorando su un sito di e-commerce. Stai salvando il saldo totale del carrello dell'utente in una variabile "totalShoppingCart".
  C'è una promozione in corso: se il totale del carrello supera 50, l'utente ha diritto alla spedizione gratuita (altrimenti la spedizione ha un costo fisso pari a 10).
  Crea un algoritmo che determini l'ammontare totale che deve essere addebitato all'utente per il checkout.
*/

/* SCRIVI QUI LA TUA RISPOSTA */

let totalShoppingCart= 45;

if (totalShoppingCart>50){
  console.log( "spedizione grtuita", totalShoppingCart)
}

else {
  totalShoppingCart=totalShoppingCart+10;
  console.log("paghi 10 €  in più ", totalShoppingCart)
}

/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ESERCIZIO 6
  Stai lavorando su un sito di e-commerce. Oggi è il Black Friday e viene applicato il 20% su ogni prodotto.
  Modifica la risposta precedente includendo questa nuova promozione nell'algoritmo, determinando come prima se le spedizioni sono gratuite oppure no e e calcolando il totale.
*/

/* SCRIVI QUI LA TUA RISPOSTA */
let prezzoScontato;
if (totalShoppingCart>50){
  prezzoScontato= totalShoppingCart-((totalShoppingCart *20)/100);
  console.log( "spedizione grtuita il totale è ", prezzoScontato )
}

else {
  prezzoScontato= ((totalShoppingCart /100)*20);
  totalShoppingCart= totalShoppingCart-prezzoScontato;
  totalShoppingCart= totalShoppingCart +10;
  console.log(totalShoppingCart);
}

/*++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ESERCIZIO 7
  Crea tre variabili, e assegna un valore numerico a ciascuna di esse.
  Utilizzando un blocco condizionale, crea un algoritmo per ordinarle secondo il loro valore, dal più alto al più basso.
  Alla fine mostra il risultato in console.
*/

/* SCRIVI QUI LA TUA RISPOSTA */

let variabile1= 45;
let variabile2 = 50;
let  variabile3= 20;

console.log( variabile1, variabile2, variabile3)

if ((  variabile1 > variabile2) && (variabile1>variabile3))
{
      if (variabile2>variabile3)
        console.log( variabile1, variabile2, variabile3)
      else 
      console.log (variabile1, variabile3, variabile2)
      }

else if ((  variabile2 > variabile1) && (variabile2>variabile3))
{
      if (variabile1>variabile3)
      console.log( variabile2, variabile1, variabile3)
       else 
       console.log (variabile2, variabile3, variabile1)
}

else 
{
  if (variabile2>variabile1)
  console.log( variabile3, variabile2, variabile1)
   else 
   console.log (variabile3, variabile1, variabile2)
}


/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ESERCIZIO 8
  Crea un algoritmo per verificare che un valore fornito sia un numero oppure no (suggerimento: cerca su un motore di ricerca "typeof").
*/

/* SCRIVI QUI LA TUA RISPOSTA */
let valore= "pippo";

if (typeof valore === "number")
  console.log("Il valore è un numero.");

  else {
    console.log("Il valore non è un numero.");}

/*++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ESERCIZIO 9
  Crea un algoritmo per controllare se un numero fornito sia pari o dispari (suggerimento: cerca l'operatore modulo su un motore di ricerca)
*/

/* SCRIVI QUI LA TUA RISPOSTA */
let numero = 7;

if (numero % 2 === 0) {
    console.log(numero + " è un numero pari.");
} else {
    console.log(numero + " è un numero dispari.");
}

/*++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ESERCIZIO 10
  Modifica la logica del seguente algoritmo in modo che mostri in console il messaggio corretto in ogni circostanza.
  let val = 7
  if (val < 10 ) {
      console.log("Meno di 10");
    } else if (val < 5) {
      console.log("Meno di 5");
    } else {
      console.log("Uguale a 10 o maggiore");
    }
*/

/* SCRIVI QUI LA TUA RISPOSTA */

let val = 7
  if  (val < 5) {
      console.log("Meno di 5");
    } 
       
    else if ((val < 10 )&&(val>5)) {
      console.log("Meno di 10 e maggiore di 5");
    } 
    else {
      console.log("Uguale a 10 o maggiore");
    }

/* ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ESERCIZIO 11
  Fornito il seguente oggetto, scrivi del codice per aggiungere una proprietà "city", il cui valore sarà "Toronto".
*/

const me = {
  name: 'John',
  lastName: 'Doe',
  skills: ['javascript', 'html', 'css'],
}

me. city= "Toronto";
console.log(me)

/* SCRIVI QUI LA TUA RISPOSTA */

/* ESERCIZIO 12
  Lavorando sempre sull'oggetto precedentemente fornito, scrivi del codice per rimuovere la proprietà "lastName".
  
*/

/* SCRIVI QUI LA TUA RISPOSTA */
delete me.lastName;
    console.log(me) 

/* ESERCIZIO 13
  Lavorando sempre sull'oggetto precedentemente fornito, scrivi del codice per rimuovere l'ultimo elemento della proprietà "skills".
*/

/* SCRIVI QUI LA TUA RISPOSTA */
delete me.skills;
    console.log(me)

/* ESERCIZIO 14
  Scrivi del codice per creare un array inizialmente vuoto. Riempilo successivamente con i numeri da 1 a 10.
*/

/* SCRIVI QUI LA TUA RISPOSTA */
var numeriArray= [ ];
numeriArray.push(1);
numeriArray.push(2)
numeriArray.push(3)
numeriArray.push(4)
numeriArray.push(5)
numeriArray.push(6)
numeriArray.push(7)
numeriArray.push(8)
numeriArray.push(9)
numeriArray.push(10)
console.log(numeriArray.length)
console.log( numeriArray);

/* ESERCIZIO 15
  Scrivi del codice per sostituire l'ultimo elemento dell'array, ovvero il valore 10, con il valore 100.
*/
numeriArray.pop();  
numeriArray.push("100")
console.log (numeriArray)

/* SCRIVI QUI LA TUA RISPOSTA*/
