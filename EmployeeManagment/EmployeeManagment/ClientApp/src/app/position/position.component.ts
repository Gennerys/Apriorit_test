import { Component, Inject } from "@angular/core";
import { HttpClient } from '@angular/common/http';

@Component({
  selector: "position-list",
  templateUrl: "position.component.html",
  styleUrls: []
})

export class PositionComponent {
  public positions: IPosition[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<IPosition[]>(baseUrl + 'position').subscribe(result => {
      this.positions = result;
    }, error => console.error(error));
  }
}

interface IPosition {
  positionName: string;
}
