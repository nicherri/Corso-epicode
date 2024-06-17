const numeriTabellone = fillArray(); // Popola l'array numeriTabellone

const createTabel = function () {
    const calendarDiv = document.getElementById('tabellone');
    for (let i = 0; i < 90; i++) {
        const cellDiv = document.createElement('div');
        cellDiv.classList.add('numero');
        cellDiv.innerText = i + 1;
        calendarDiv.appendChild(cellDiv);
        cellDiv.classList.add('cella');
    }
}

// Popola l'array numeriTabellone con numeri da 1 a 90
function fillArray() {
    const arr = [];
    for (let i = 0; i < 90; i++) {
        arr.push(i + 1);
    }
    return arr;
}

const getRandomNum = function (range) {
    const randomIndex = Math.floor(Math.random() * range.length);
    const random = range.splice(randomIndex, 1)[0];
    return random;
}

const generateRandNumber = function () {
    const BtnNumber = document.getElementById("round_namber");
    BtnNumber.addEventListener("click", function (e) {
        const casualeNumero = getRandomNum(numeriTabellone);
        document.getElementById('randNum').textContent = "Numero casuale: " + casualeNumero;

        const divsNumeri = document.querySelectorAll('.numero');

        for (let i = 0; i < divsNumeri.length; i++) {
            const currentDiv = divsNumeri[i];
            const divNumero = parseInt(currentDiv.innerText);
            if (divNumero === casualeNumero) {
                currentDiv.classList.add('evidenziato');
            }
        }
    });
}

createTabel();
generateRandNumber();
