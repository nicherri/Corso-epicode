import { Component } from '@angular/core';
import { iPost } from '../../Model/i-post';
import { iComponentiJson } from '../../Model/componenti-json';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {
    postArr:iPost[]=[];
    firstPost!:iPost;


    ngOnInit(){
      this.getPost()

      let firstPost=this.getFistPost()

      if(firstPost){
        this.firstPost=firstPost
      }
    }

    async getPost(){
      const responsive =await fetch ('../../../assets/script/db.json')
      const posts =<iComponentiJson> await responsive.json()
      this.postArr =posts.posts;
      console.log(this.postArr)
    }
getFistPost(){

  return this.postArr.shift()
}

}
