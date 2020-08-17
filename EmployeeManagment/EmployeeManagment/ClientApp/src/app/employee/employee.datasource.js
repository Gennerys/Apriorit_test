"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.EmployeeDataSource = void 0;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var EmployeeDataSource = /** @class */ (function () {
    function EmployeeDataSource(employeeService) {
        this.employeeService = employeeService;
        this.employeesSubject = new rxjs_1.BehaviorSubject([]);
        this.loadingSubject = new rxjs_1.BehaviorSubject(false);
        this.loading$ = this.loadingSubject.asObservable();
    }
    EmployeeDataSource.prototype.connect = function ( /*collectionViewer: CollectionViewer*/) {
        console.log("Connecting data source");
        return this.employeesSubject.asObservable();
    };
    EmployeeDataSource.prototype.disconnect = function ( /*collectionViewer: CollectionViewer*/) {
        this.employeesSubject.complete();
        this.loadingSubject.complete();
    };
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
    EmployeeDataSource.prototype.loadEmployees = function () {
        var _this = this;
        this.loadingSubject.next(true);
        this.employeeService.findEmployees().pipe(operators_1.catchError(function () { return rxjs_1.of([]); }), operators_1.finalize(function () { return _this.loadingSubject.next(false); }))
            .subscribe(function (employees) { return _this.employeesSubject.next(employees); });
    };
    return EmployeeDataSource;
}());
exports.EmployeeDataSource = EmployeeDataSource;
//# sourceMappingURL=employee.datasource.js.map