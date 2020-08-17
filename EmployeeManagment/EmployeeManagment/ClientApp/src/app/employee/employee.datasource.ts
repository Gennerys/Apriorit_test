import { CollectionViewer, DataSource } from "@angular/cdk/collections";
import { IEmployee } from "./employee.model";
import { BehaviorSubject, Observable, of } from "rxjs";
import { EmployeeService } from "./employee.service";
import { catchError, finalize } from "rxjs/operators";


export class EmployeeDataSource implements DataSource<IEmployee> {

  private employeesSubject = new BehaviorSubject<IEmployee[]>([]);
  private loadingSubject = new BehaviorSubject<boolean>(false);

  public loading$ = this.loadingSubject.asObservable();

  constructor(private employeeService: EmployeeService) { }

  connect(/*collectionViewer: CollectionViewer*/): Observable<IEmployee[]> {
    console.log("Connecting data source");
    return this.employeesSubject.asObservable();
  }

  disconnect(/*collectionViewer: CollectionViewer*/): void {
    this.employeesSubject.complete();
    this.loadingSubject.complete();
  }

  //loadLessons( filter = '',
  //  sortDirection = 'asc', pageIndex = 0, pageSize = 3) {

  //  this.loadingSubject.next(true);

  //   this.employeeService.findEmployees(filter, sortDirection,
  //    pageIndex, pageSize).pipe(
  //      catchError(() => of([])),
  //      finalize(() => this.loadingSubject.next(false))
  //    )
  //    .subscribe((employees: IEmployee[]) => this.employeesSubject.next(employees));
  //}
  loadEmployees() {

    this.loadingSubject.next(true);

    this.employeeService.findEmployees().pipe(
        catchError(() => of([])),
        finalize(() => this.loadingSubject.next(false))
      )
      .subscribe((employees: IEmployee[]) => this.employeesSubject.next(employees));
  }
}
