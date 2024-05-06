// crazione della classe

class User {
    constructor(_firstName, _lastName, _age, _location){
        this.firstName= _firstName
        this.lastName= _lastName
        this.age= _age
        this.location=_location
    }
    compareAge(otherUser) {
        if (this.age > otherUser.age) {
          return `${this.firstName} è più vecchio di ${otherUser.firstName}`;
        } else if (this.age < otherUser.age) {
          return `${this.firstName} è più giovane di ${otherUser.firstName}`;
        } else {
          return `${this.firstName} ha la stessa età di ${otherUser.firstName}`;
        }
      }
}

const luca = new User(
    'Luca',
    'Rossi',
    25,
    'Napoli'
);

console.log('Luca', luca)

const maria= new User(
    'Maria',
    'Giacomini',
    30,
    'Taranto'
)

console.log('Maria', maria)

console.log(luca.compareAge(maria)); // Output: Mario è più vecchio di Luigi

