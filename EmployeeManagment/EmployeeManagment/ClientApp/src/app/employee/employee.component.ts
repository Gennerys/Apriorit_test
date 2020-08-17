import { Component, Inject, OnInit, ViewChild } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { MatTableModule, MatTableDataSource } from '@angular/material/table';
import { EmployeeDataSource } from "./employee.datasource";
import { EmployeeService } from "./employee.service";
import { IEmployee } from "./employee.model";
import { DatePipe } from '@angular/common';
import { MatPaginator } from '@angular/material/paginator';
import { ActivatedRoute } from "@angular/router";
import { MatDialog, MatDialogConfig } from "@angular/material";
import { EmployeeDialogComponent } from "./employeeDialog.component";



@Component({
  selector: "employee-list",
  templateUrl: "employee.component.html",
  styleUrls: []
})

export class EmployeeComponent implements OnInit {

  dataSource: EmployeeDataSource;
  displayedColumns = ['name', 'surname', 'salary', 'positionName', 'hireDate', 'dateOfDissmisal'];

  constructor(private employeesService: EmployeeService,
  private dialog : MatDialog) { }

  ngOnInit() {
    this.dataSource = new EmployeeDataSource(this.employeesService);
    this.dataSource.loadEmployees();
    console.log(this.dataSource);
  }

  onCreate() {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = false;
    dialogConfig.autoFocus = true;
    this.dialog.open(EmployeeDialogComponent, dialogConfig);
  }
}


