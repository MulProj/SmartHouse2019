import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ClientApp';
}

export interface House{
  houseId?: number;
  description?: string;
  sensors?: Sensor[];
  
}
export interface Sensor{
  temperature?: number;
  humidity?: number;
  smoke?: number;
  isMove?: number;
  sensorId?: number;
  isOn?: boolean;
  houseId?: number;
  house?: House[];
}
