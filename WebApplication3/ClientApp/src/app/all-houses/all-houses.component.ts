import { Component, OnInit } from '@angular/core';
import { HttpService } from '../Service/http.service';
import { Observable } from 'rxjs';
import { House } from '../app.component';

@Component({
  selector: 'app-all-houses',
  templateUrl: './all-houses.component.html',
  styleUrls: ['./all-houses.component.css']
})
export class AllHousesComponent implements OnInit{



  constructor(private httpService: HttpService) { }
  allHouses$: Observable<Array<House>>
  
    ngOnInit(): void {
      this.allHouses$ = this.httpService.getHouses()
    }

    addHouse(){
      const h: House=({
        description: 'Opis dodanego domu',
      });

      this.httpService.addHouse(h).subscribe(house=>{
        console.log(house);
      })


    }
    toF(a)
    {
      console.log(a);
    }

  }



  


