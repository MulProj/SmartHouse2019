import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { House, Sensor } from '../all-houses/all-houses.component';
import { Observable } from 'rxjs';

@Injectable()

export class HttpService {

  constructor(private http: HttpClient) { }

  getHouses(): Observable<Array<House>>{
    return this.http.get<Array<House>>('https://localhost:5001/api/houses/gethouses');
  }

  getSensors() :Observable<Array<Sensor>>{
    return this.http.get<Array<Sensor>>('https://localhost:5001/api/sensors/getsensors')
  }
}
