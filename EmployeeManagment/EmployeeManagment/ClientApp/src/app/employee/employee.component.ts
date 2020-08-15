import { Component, Inject } from "@angular/core";
import { HttpClient } from '@angular/common/http';



@Component({
  selector: "employee-list",
  templateUrl: "employee.component.html",
  styleUrls: []
})

export class EmployeeComponent {
  public employees: IEmployee[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<IEmployee[]>(baseUrl + 'employee').subscribe(result => {
      this.employees = result;
    }, error => console.error(error));
  }
}

interface IEmployee {
  name: string;
  surname: string;
  salary: number;
  positionName: string;
  hireDate: Date;
  dateOfDissmisal: Date;
}
