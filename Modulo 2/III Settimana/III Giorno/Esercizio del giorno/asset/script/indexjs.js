// Ottieni l'anno corrente
const annoCorrente = new Date().getFullYear();
// Imposta l'anno corrente nell'elemento con id "anno"
document.getElementById("anno").innerText = annoCorrente;

// Funzione per ottenere i libri dall'API
const fetchBook = function () {
  return new Promise((resolve, reject) => {
    // Effettua una richiesta GET all'API per ottenere i libri
    fetch("https://striveschool-api.herokuapp.com/books")
      .then((response) => {
        // Controlla se la risposta è ok
        if (response.ok) {
          console.log("Richiesta completata con successo!", response);
          return response.json(); // Converte la risposta in formato JSON
        } else {
          // Se la risposta non è ok, gestisci diversi casi di errore
          if (response.status === 404) {
            throw new Error("La risorsa richiesta non è stata trovata");
          } else if (response.status === 500) {
            throw new Error("La risposta del server è stata negativa");
          }
        }
      })
      .then((arrayOfUsers) => {
        // Quando i dati dei libri sono stati ottenuti con successo, passali alla funzione per generarli sulla pagina
        console.log(
          "Dati dei libri ottenuti con successo:",
          arrayOfUsers
        );
        generateList(arrayOfUsers);
      })
      .catch((err) => {
        // Gestisci gli errori eventuali
        console.log("Errore durante il recupero dei libri:", err);
      });
  });
};

// Funzione per generare la lista dei libri sulla pagina
const generateList = function (books) {
  // Ottieni il container dei libri
  const booksContainer = document.getElementById("booksContainer");

  // Itera su ogni libro e crea una card Bootstrap per ognuno
  books.forEach((book) => {
    const card = document.createElement("div");
    card.classList.add("col-md-3");

    card.innerHTML = `
        <div class="card mt-3">
          <img src="${book.img}" class="card-img-top" alt="${book.title}">
          <div class="card-body">
            <h5 class="card-title">${book.title}</h5>
            <p class="card-text">${book.price}€</p>
            <button class="btn btn-primary addToCart" data-id="${book.asin}">Aggiungi al carrello</button>
            <button class="btn btn-danger discardBook" data-id="${book.asin}">Scarta</button>
          </div>
        </div>
      `;

    // Aggiungi la card al container dei libri
    booksContainer.appendChild(card);
  });

  // Aggiungi event listener ai pulsanti
  document.querySelectorAll(".addToCart").forEach((button) => {
    button.addEventListener("click", addToCart);
  });

  document.querySelectorAll(".discardBook").forEach((button) => {
    button.addEventListener("click", discardBook);
  });
};

// Esegui la chiamata per ottenere i libri e renderli sulla pagina
fetchBook();

// Funzione per aggiungere un libro al carrello
function addToCart(event) {
  const bookId = event.target.dataset.id;
  const book = document.querySelector(`.addToCart[data-id="${bookId}"]`).parentNode.parentNode.cloneNode(true);

  const cart = document.getElementById('cart');
  cart.appendChild(book);

  // Aggiungi un pulsante per rimuovere il libro dal carrello
  const removeButton = document.createElement('button');
  removeButton.classList.add('btn', 'btn-danger', 'removeFromCart');
  removeButton.innerText = 'Rimuovi dal carrello';
  book.querySelector('.card-body').appendChild(removeButton);

  // Aggiungi un event listener per rimuovere il libro dal carrello
  removeButton.addEventListener('click', removeFromCart);
}

// Funzione per rimuovere un libro dal carrello
function removeFromCart(event) {
  const book = event.target.parentNode.parentNode;
  book.remove();
}

// Funzione per rimuovere una card libro dalla pagina
function discardBook(event) {
  const book = event.target.parentNode.parentNode;
  book.remove();
}
