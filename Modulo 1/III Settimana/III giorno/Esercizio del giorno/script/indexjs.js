const inizio = function(x) {
    x.preventDefault();
    aggiungitask();
    agganciaretask();
    eliminatask();
}

const aggiungitask = function() {
    const tasks = document.querySelector("#tasksecondaria");
    const inputField = document.querySelector("#Primatask input");

    let newtask = `
    <div class="name"> 
        <span id="nometask">${inputField.value}</span>
        <button class="delete"><i class="far fa-trash-alt"></i></button>
    </div>
    `;
    tasks.innerHTML += newtask;
    inputField.value = ""; // Pulisce l'input dopo aver aggiunto il task
}

const agganciaretask = function () {
    let allname = document.querySelectorAll('.name')
    allname.forEach(name => {
        name.addEventListener('click', function () {
            this.classList.toggle('completed')
        })
    });
}

const eliminatask = function () {
    const attachDelete = function () {
        let allDeleteButtons = document.querySelectorAll('.delete')
        allDeleteButtons.forEach(button => {
            button.addEventListener('click', function () {
                this.parentNode.remove();
            });
        });
    };
    
    attachDelete(); // Chiamata a attachDelete per agganciare gli eventi di eliminazione
};

window.onload = function () {
    let form = document.querySelector('form')
    form.addEventListener('submit', inizio)
}