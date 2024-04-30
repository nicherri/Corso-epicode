/*
REGOLE
- Tutte le risposte devono essere scritte in JavaScript
- Se sei in difficoltà puoi chiedere aiuto a un Teaching Assistant
- Puoi usare Google / StackOverflow ma solo quanto ritieni di aver bisogno di qualcosa che non è stato spiegato a lezione
- Puoi testare il tuo codice in un file separato, o de-commentando un esercizio alla volta
- Per farlo puoi utilizzare il terminale Bash, quello di VSCode o quello del tuo sistema operativo (se utilizzi macOS o Linux)
*/

// JS Basics

/* ESERCIZIO A
  Crea una variabile chiamata "sum" e assegnaci il risultato della somma tra i valori 10 e 20.
*/
console.log( 'esercizio A');

const sum= function (x, y) {
  return x+=y;
} ;
console.log(sum(10, 20));



/* ESERCIZIO B
  Crea una variabile chiamata "random" e assegnaci un numero casuale tra 0 e 20 (deve essere generato dinamicamente a ogni esecuzione).
*/
console.log( 'esercizio B');
const random= function () {
  return  Math.floor(Math.random() * 21);;
} ;
console.log(random ());

/* ESERCIZIO C
  Crea una variabile chiamata "me" e assegnaci un oggetto contenente le seguenti proprietà: name = il tuo nome, surname = il tuo cognome, age = la tua età.
*/
console.log( 'esercizio C');
const me = {
  nome: "Nicola", 
  cognome: "Schirripa", 
  eta:26
};    

console.log ("me", me)

/* ESERCIZIO D
  Crea del codice per rimuovere programmaticamente la proprietà "age" dall'oggetto precedentemente creato.
*/
console.log( 'esercizio D');

delete me.eta;
console.log(me) // undefined


/* ESERCIZIO E
  Crea del codice per aggiungere programmaticamente all'oggetto precedentemente creato un array chiamato "skills", contenente i linguaggi di programmazione che conosci.
*/
console.log( 'esercizio E');

me.skills = ["JavaScript", "HTML", "CSS"];
console.log(me); 

/* ESERCIZIO F
  Crea un pezzo di codice per aggiungere un nuovo elemento all'array "skills" contenuto nell'oggetto "me".
*/
console.log( 'esercizio F');

me.skills.push("Angular");
console.log(me); 


/* ESERCIZIO G
  Crea un pezzo di codice per rimuovere programmaticamente l'ultimo elemento dall'array "skills" contenuto nell'oggetto "me".
*/
console.log( 'esercizio  G');
me.skills.pop();

console.log(me); 

/* ESERCIZIO 1
  Crea una funzione chiamata "dice": deve generare un numero casuale tra 1 e 6.
*/
console.log( 'esercizio 1');

function dice() {
  return Math.floor(Math.random()*7);
}

console.log( dice());

/* ESERCIZIO 2
  Crea una funzione chiamata "whoIsBigger" che riceve due numeri come parametri e ritorna il maggiore dei due.
*/
console.log( 'esercizio 2');


const whoIsBigger = function (num1,num2) {
   if ( num1>num2)
   return num1;
  else 
  return num2 ;
};
console.log(whoIsBigger(89, 47),); 

/* ESERCIZIO 3
  Crea una funzione chiamata "splitMe" che riceve una stringa come parametro e ritorna un'array contenente ogni parola della stringa.

  Es.: splitMe("I love coding") => ritorna ["I", "Love", "Coding"]
*/
console.log( 'esercizio 3');


function splitMe(string) {
  const parole= string.split (" ");
  const arrayParole= [];

  parole.forEach(parola => {
    arrayParole.push(parola);
    
  });
  return arrayParole;
}
  console.log(splitMe("I love coding") )


/* ESERCIZIO 4
  Crea una funzione chiamata "deleteOne" che riceve una stringa e un booleano come parametri.
  Se il valore booleano è true la funzione deve ritornare la stringa senza il primo carattere, altrimenti la deve ritornare senza l'ultimo.
*/

console.log( 'esercizio 4');


function deleteOne(stringa, eliminaPrimo) {
  if (eliminaPrimo) {
    return stringa.substring(1);
  } else {
    return stringa.substring(0, stringa.length - 1);
  }
}

console.log(deleteOne("ciao", true)); // Elimina il primo carattere: "iao"
console.log(deleteOne("ciao", false)); // Elimina l'ultimo carattere: "cia"


/* ESERCIZIO 5
  Crea una funzione chiamata "onlyLetters" che riceve una stringa come parametro e la ritorna eliminando tutte le cifre numeriche.

  Es.: onlyLetters("I have 4 dogs") => ritorna "I have dogs"
*/
console.log( 'esercizio 5');

function onlyLetters(string) {
  return string.replace(/[0-9]/g, "");
  
}
console.log ( onlyLetters("I have 4 dogs" ));

/* ESERCIZIO 6
  Crea una funzione chiamata "isThisAnEmail" che riceve una stringa come parametro e ritorna true se la stringa è un valido indirizzo email.
*/
console.log( 'esercizio 6');

function isThisAnEmail(string) {
  
  
}

/* ESERCIZIO 7
  Scrivi una funzione chiamata "whatDayIsIt" che ritorna il giorno della settimana corrente.
*/
console.log( 'esercizio 7');
function whatDayIsIt() {
 
  const giorniSettimana = ["Domenica", "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato"];
  const dataCorrente = new Date();
  const numeroGiorno = dataCorrente.getDay();
  const nomeGiorno = giorniSettimana[numeroGiorno];
  return nomeGiorno;
}

console.log(whatDayIsIt()); 

 

/* ESERCIZIO 8
  Scrivi una funzione chiamata "rollTheDices" che riceve un numero come parametro.
  Deve invocare la precedente funzione dice() il numero di volte specificato nel parametro, e deve tornare un oggetto contenente una proprietà "sum":
  il suo valore deve rappresentare il totale di tutti i valori estratti con le invocazioni di dice().
  L'oggetto ritornato deve anche contenere una proprietà "values", contenente un array con tutti i valori estratti dalle invocazioni di dice().

  Example:
  rollTheDices(3) => ritorna {
      sum: 10
      values: [3, 3, 4]
  }
*/
console.log( 'esercizio 8');


function rollTheDices(numeroChiamate) {
  let sum = 0;
  const values = [];

  for (let i = 0; i < numeroChiamate; i++) {
    const result = dice(); 
    sum += result; 
    values.push(result); 
  }

  return { sum: sum, values: values };
}
console.log(rollTheDices(10));

/* ESERCIZIO 9
  Scrivi una funzione chiamata "howManyDays" che riceve una data come parametro e ritorna il numero di giorni trascorsi da tale data.
*/

console.log( 'esercizio 9');

function howManyDays(data) {
  const dataCorrente = new Date();
  const differenzaGiorni = Math.floor((dataCorrente - data) / (1000 * 60 * 60 * 24));
  return differenzaGiorni;
}
const dataFornita = new Date('2023-01-01'); 
console.log(howManyDays(dataFornita))



/* ESERCIZIO 10
  Scrivi una funzione chiamata "isTodayMyBirthday" che deve ritornare true se oggi è il tuo compleanno, falso negli altri casi.
*/
console.log( 'esercizio 10');
function isTodayMyBirthday(dataCompleanno) {
  const dataOdienra = new Date();

  const giornoCorrente = dataOdienra.getDate();
  const meseCorrente = dataOdienra.getMonth() + 1; 
  const giornoCompleanno = dataCompleanno.getDate();
  const meseCompleanno = dataCompleanno.getMonth() + 1;
  

  if (giornoCorrente === giornoCompleanno && meseCorrente === meseCompleanno) {
    return true;
  } else {
    return false;
  }
}

const compleanno = new Date('1997-07-01'); 
console.log(isTodayMyBirthday(compleanno)); 


// Arrays & Oggetti


const movies = [
  {
    Title: 'The Lord of the Rings: The Fellowship of the Ring',
    Year: '2001',
    imdbID: 'tt0120737',
    Type: 'movie',
    Poster:
      'https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_SX300.jpg',
  },

  {
    Title: 'The Lord of the Rings: The Return of the King',
    Year: '2003',
    imdbID: 'tt0167260',
    Type: 'movie',
    Poster:
      'https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg',
  },
  {
    Title: 'The Lord of the Rings: The Two Towers',
    Year: '2002',
    imdbID: 'tt0167261',
    Type: 'movie',
    Poster:
      'https://m.media-amazon.com/images/M/MV5BNGE5MzIyNTAtNWFlMC00NDA2LWJiMjItMjc4Yjg1OWM5NzhhXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg',
  },
  {
    Title: 'Lord of War',
    Year: '2005',
    imdbID: 'tt0399295',
    Type: 'movie',
    Poster:
      'https://m.media-amazon.com/images/M/MV5BMTYzZWE3MDAtZjZkMi00MzhlLTlhZDUtNmI2Zjg3OWVlZWI0XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg',
  },
  {
    Title: 'Lords of Dogtown',
    Year: '2005',
    imdbID: 'tt0355702',
    Type: 'movie',
    Poster:
      'https://m.media-amazon.com/images/M/MV5BNDBhNGJlOTAtM2ExNi00NmEzLWFmZTQtYTZhYTRlNjJjODhmXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg',
  },
  {
    Title: 'The Lord of the Rings',
    Year: '1978',
    imdbID: 'tt0077869',
    Type: 'movie',
    Poster:
      'https://m.media-amazon.com/images/M/MV5BOGMyNWJhZmYtNGQxYi00Y2ZjLWJmNjktNTgzZWJjOTg4YjM3L2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SX300.jpg',
  },
  {
    Title: 'Lord of the Flies',
    Year: '1990',
    imdbID: 'tt0100054',
    Type: 'movie',
    Poster:
      'https://m.media-amazon.com/images/M/MV5BOTI2NTQyODk0M15BMl5BanBnXkFtZTcwNTQ3NDk0NA@@._V1_SX300.jpg',
  },
  {
    Title: 'The Lords of Salem',
    Year: '2012',
    imdbID: 'tt1731697',
    Type: 'movie',
    Poster:
      'https://m.media-amazon.com/images/M/MV5BMjA2NTc5Njc4MV5BMl5BanBnXkFtZTcwNTYzMTcwOQ@@._V1_SX300.jpg',
  },
  {
    Title: 'Greystoke: The Legend of Tarzan, Lord of the Apes',
    Year: '1984',
    imdbID: 'tt0087365',
    Type: 'movie',
    Poster:
      'https://m.media-amazon.com/images/M/MV5BMTM5MzcwOTg4MF5BMl5BanBnXkFtZTgwOTQwMzQxMDE@._V1_SX300.jpg',
  },
  {
    Title: 'Lord of the Flies',
    Year: '1963',
    imdbID: 'tt0057261',
    Type: 'movie',
    Poster:
      'https://m.media-amazon.com/images/M/MV5BOGEwYTlhMTgtODBlNC00ZjgzLTk1ZmEtNmNkMTEwYTZiM2Y0XkEyXkFqcGdeQXVyMzU4Nzk4MDI@._V1_SX300.jpg',
  },
  {
    Title: 'The Avengers',
    Year: '2012',
    imdbID: 'tt0848228',
    Type: 'movie',
    Poster:
      'https://m.media-amazon.com/images/M/MV5BNDYxNjQyMjAtNTdiOS00NGYwLWFmNTAtNThmYjU5ZGI2YTI1XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SX300.jpg',
  },
  {
    Title: 'Avengers: Infinity War',
    Year: '2018',
    imdbID: 'tt4154756',
    Type: 'movie',
    Poster:
      'https://m.media-amazon.com/images/M/MV5BMjMxNjY2MDU1OV5BMl5BanBnXkFtZTgwNzY1MTUwNTM@._V1_SX300.jpg',
  },
  {
    Title: 'Avengers: Age of Ultron',
    Year: '2015',
    imdbID: 'tt2395427',
    Type: 'movie',
    Poster:
      'https://m.media-amazon.com/images/M/MV5BMTM4OGJmNWMtOTM4Ni00NTE3LTg3MDItZmQxYjc4N2JhNmUxXkEyXkFqcGdeQXVyNTgzMDMzMTg@._V1_SX300.jpg',
  },
  {
    Title: 'Avengers: Endgame',
    Year: '2019',
    imdbID: 'tt4154796',
    Type: 'movie',
    Poster:
      'https://m.media-amazon.com/images/M/MV5BMTc5MDE2ODcwNV5BMl5BanBnXkFtZTgwMzI2NzQ2NzM@._V1_SX300.jpg',
  },
]

// NOTA: l'array "movies" usato in alcuni esercizi è definito alla fine di questo file

/* ESERCIZIO 11
  Scrivi una funzione chiamata "deleteProp" che riceve un oggetto e una stringa come parametri; deve ritornare l'oggetto fornito dopo aver eliminato
  in esso la proprietà chiamata come la stringa passata come secondo parametro.
*/
console.log( 'esercizio 11');

function deleteProp (oggeto, skills){
  if (skills in oggeto){
    delete oggetto[skills]
  }
  return oggeto;
}

const result=deleteProp (me, 'age');
console.log(result);

/* ESERCIZIO 12
  Scrivi una funzione chiamata "newestMovie" che trova il film più recente nell'array "movies" fornito.
*/
console.log( 'esercizio 12');
const newestMovie = (movies) => {
  const newest = movies.reduce((prev, current) => {
    const prevYear = parseInt(prev.Year);
    const currentYear = parseInt(current.Year);
    return (prevYear > currentYear) ? prev : current;
  });

  return newest;
};

console.log(newestMovie(movies));

/* ESERCIZIO 13
  Scrivi una funzione chiamata countMovies che ritorna il numero di film contenuti nell'array "movies" fornito.
*/
console.log( 'esercizio 13');
const countMovies =function () {
  return movies.length;
  
}
console.log(countMovies(movies));

/* ESERCIZIO 14
  Scrivi una funzione chiamata "onlyTheYears" che crea un array con solamente gli anni di uscita dei film contenuti nell'array "movies" fornito.
*/
console.log( 'esercizio 14');
function onlyYears(movies) {
  let onlyTheYears = [];
  for (let i = 0; i < movies.length; i++) {
    onlyTheYears.push(movies[i].Year);
  }
  return onlyTheYears;
}

console.log(onlyYears(movies));


/* ESERCIZIO 15
  Scrivi una funzione chiamata "onlyInLastMillennium" che ritorna solamente i film prodotto nel millennio scorso contenuti nell'array "movies" fornito.
*/

console.log( 'esercizio 15');

const onlyInLastMillennium = (movies) => {
  const lastMillenniumMovies = [];

  for (let i = 0; i < movies.length; i++) {
    const movieYear = parseInt(movies[i].Year);
    
    if (movieYear > 2000) {
      lastMillenniumMovies.push(movies[i]);
    }
  }

  return lastMillenniumMovies;
};

// Esempio di utilizzo della funzione con l'array di film fornito
console.log(onlyInLastMillennium(movies));


/* ESERCIZIO 16
  Scrivi una funzione chiamata "sumAllTheYears" che ritorna la somma di tutti gli anni in cui sono stati prodotti i film contenuti nell'array "movies" fornito.
*/
console.log( 'esercizio 16');
const sumAllTheYears = (movies) => {
  let sum = 0;

  for (let i = 0; i < movies.length; i++) {
    sum += parseInt(movies[i].Year);
  }

  return sum;
};

console.log(sumAllTheYears(movies));


/* ESERCIZIO 17
  Scrivi una funzione chiamata "searchByTitle" che riceve una stringa come parametro e ritorna i film nell'array "movies" fornito che la contengono nel titolo.
*/
console.log( 'esercizio 17');

const searchByTitle = (movies, searchString) => {
  const foundMovies = [];

  for (let i = 0; i < movies.length; i++) {
    if (movies[i].Title.toLowerCase().search(searchString.toLowerCase()) !== -1) {
      foundMovies.push(movies[i]);
    }
  }

  return foundMovies;
};

console.log(searchByTitle(movies, "Lord"));

/* ESERCIZIO 18
  Scrivi una funzione chiamata "searchAndDivide" che riceve una stringa come parametro e ritorna un oggetto contenente due array: "match" e "unmatch".
  "match" deve includere tutti i film dell'array "movies" fornito che contengono la stringa fornita all'interno del proprio titolo, mentre "unmatch" deve includere tutti i rimanenti.
*/
console.log( 'esercizio 18');
const searchAndDivide = (movies, searchString) => {
  const match = [];
  const unmatch = [];

  for (let i = 0; i < movies.length; i++) {
    if (movies[i].Title.toLowerCase().search(searchString.toLowerCase()) !== -1) {
      match.push(movies[i]);
    }
    else
    unmatch.push(movies[i]);
  }

  return   { match, unmatch };;
};

console.log(searchAndDivide(movies, "Lord"));


/* ESERCIZIO 19
  Scrivi una funzione chiamata "removeIndex" che riceve un numero come parametro e ritorna l'array "movies" fornito privo dell'elemento nella posizione ricevuta come parametro.
*/
console.log( 'esercizio 19');
function removeIndex(movies, numero) {
  const peggioramentoDiMovies = { ...movies };
  delete peggioramentoDiMovies[numero];
  return peggioramentoDiMovies;
}

// Esempio d'uso:
const peggioramentoDiMovies = removeIndex(movies, 2);
console.log(peggioramentoDiMovies);

// DOM (nota: gli elementi che selezionerai non si trovano realmente nella pagina)

/* ESERCIZIO 20
  Scrivi una funzione per selezionare l'elemento dotato di id "container" all'interno della pagina.
*/
console.log( 'esercizio 20');
function stampaIdContainer() {
  const containerElement = document.getElementById('container');
  return containerElement;
}
const containerElement = stampaIdContainer();
console.log(containerElement);

/* ESERCIZIO 21
  Scrivi una funzione per selezionare ogni tag <td> all'interno della pagina.
*/
console.log( 'esercizio 21');
function stampatestoTDs() {
  const allTDs = document.querySelectorAll('td');
  return allTDs;
}


const allTDs = stampatestoTDs();
console.log(allTDs);


/* ESERCIZIO 22
  Scrivi una funzione che, tramite un ciclo, stampa in console il testo contenuto in ogni tag <td> all'interno della pagina.
*/
console.log( 'esercizio 22');

function stampatestoTDsciclicamente() {
  const allTDs2 = document.querySelectorAll('td');
  for (let i = 0; i < allTDs.length; i++) {
    console.log(allTDs2[i].textContent);
  }
}

stampatestoTDsciclicamente();

console.log( 'esercizio 23');
/* ESERCIZIO 24
  Scrivi una funzione per aggiungere un nuovo elemento alla lista non ordinata con id "myList".
*/
console.log( 'esercizio 24');
function creaLIsta(stringa){
  const elementiLista= documente.getElementById('myList')
  const elementimyList=document.createElement('li')
  elementimyList.textContent=stringa;
  myList.appendChild(elementimyList);

  creaLIsta('nuova lista')

/* ESERCIZIO 25
  Scrivi una funzione per svuotare la lista non ordinata con id "myList".
*/
console.log( 'esercizio 25');
function PulisciLista() {
  const myList = document.getElementById('myList');
  myList.innerHTML = '';
}

// Esempio d'uso:
PulisciLista();
/* ESERCIZIO 26
  Scrivi una funzione per aggiungere ad ogni tag <tr> la classe CSS "test"
*/
console.log( 'esercizio 26');
function AggiungereClasse() {
  const allTRs = document.getElementsByTagName('tr');
  for (let i = 0; i < allTRs.length; i++) {
    allTRs[i].classList.add('test');
  }
}

AggiungereClasse();

// [EXTRA] JS Avanzato

/* ESERCIZIO 27
  Crea una funzione chiamata "halfTree" che riceve un numero come parametro e costruisce un mezzo albero di "*" (asterischi) dell'altezza fornita.

  Esempio:
  halfTree(3)

  *
  **
  ***

*/


/* ESERCIZIO 28
  Crea una funzione chiamata "tree" che riceve un numero come parametro e costruisce un albero di "*" (asterischi) dell'altezza fornita.

  Esempio:
  tree(3)

    *
   ***
  *****

*/

/* ESERCIZIO 29
  Crea una funzione chiamata "isItPrime" che riceve un numero come parametro e ritorna true se il numero fornito è un numero primo.
*/

/* Questo array viene usato per gli esercizi. Non modificarlo. */
