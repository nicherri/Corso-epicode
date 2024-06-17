import { Component } from '@angular/core';
import { iAuto } from '../../Model/i-auto';

@Component({
  selector: 'app-ford',
  templateUrl: './ford.component.html',
  styleUrl: './ford.component.scss'
})
export class FordComponent {
  autoArr:iAuto[]=[]
  brand!: string;
  brandLogo!: string

  ngOnInit(): void {
      this.getAutos();
  }

  async getAutos() {
      const res = await fetch('../../../assets/script/db.json');
      const response = await res.json();
      this.autoArr = response;
      console.log(this.autoArr)
      this.autoArr = this.autoArr.filter((auto) => auto.brand === 'Ford')
      this.brandLogo = this.autoArr[0].brandLogo;
      this.brand = this.autoArr[0].brand;
  }

}
