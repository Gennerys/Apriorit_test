import { Injectable } from "@angular/core";
import { HttpClient, HttpParams } from "@angular/common/http";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";
import { IEmployee } from "./employee.model";

@Injectable()
export class EmployeeService {

  constructor(private http: HttpClient) {

  }

  findEmployees(): Observable<IEmployee[]> {

    return this.http.get('/employee').pipe(
      map(res => {
        res['payload'] = res;
        return res["payload"];
      })
    );
  }

  //findEmployees(
  //  filter = '', sortOrder = 'asc',
  //  pageNumber = 0, pageSize = 3): Observable<IEmployee[]> {

  //  return this.http.get('/employee', {
  //    params: new HttpParams()
  //      .set('filter', filter)
  //      .set('sortOrder', sortOrder)
  //      .set('pageNumber', pageNumber.toString())
  //      .set('pageSize', pageSize.toString())
  //  }).pipe(
  //    map(res => res["payload"])
  //  );
  //}

}
