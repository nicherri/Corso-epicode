import { iAuto } from './../../Model/i-auto';
import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {
autoArr:iAuto[]=[]
randomAutos:iAuto[]=[]
brands: string[] = [];


ngOnInit(){
this.getAuto();
}

async getAuto(){
  const responsive = await fetch ('../../../assets/script/db.json');
  const auto = await responsive.json();

  this.autoArr=auto;
  console.log(this.autoArr)
  this.fitraBrand();
  this.getRandomAuto();
console.log ('Aray deljson',this.autoArr)

}

fitraBrand(){
  this.brands = [];
  this.autoArr.forEach((auto) => {
    if (!this.brands.includes(auto.brandLogo)) { this.brands.push(auto.brandLogo); }
  });
  console.log('immagini macchine', this.brands);

}

getRandomAuto() {
  this.randomAutos = [];
  for (let i = 0; i < 2; i++) {
    let randomIndex, selectedAuto;
    do {
      randomIndex = Math.floor(Math.random() * this.autoArr.length);
      selectedAuto = this.autoArr[randomIndex];
    } while (this.randomAutos.includes(selectedAuto));
    this.randomAutos.push(selectedAuto);
  }
  console.log('2 macchine random', this.randomAutos);
}

}
