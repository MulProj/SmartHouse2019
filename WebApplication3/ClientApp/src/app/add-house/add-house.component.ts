import { Component, OnInit } from '@angular/core';
import { House } from '../app.component';
import { HttpService } from '../Service/http.service';


@Component({
  selector: 'app-add-house',
  templateUrl: './add-house.component.html',
  styleUrls: ['./add-house.component.css']
})
export class AddHouseComponent {

  opis: string
  constructor(private httpService: HttpService) { }

      addHouse(){
        const h: House=({
          description:this.opis,  
        });

        this.httpService.addHouse(h).subscribe(house=>{
        console.log(house);
    })
  }
  changeValue(event)
  {
    this.opis=event.target.value;
  }



}
