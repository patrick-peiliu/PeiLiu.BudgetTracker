import { Users } from './../../models/users';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-user-table',
  templateUrl: './user-table.component.html',
  styleUrls: ['./user-table.component.css']
})
export class UserTableComponent implements OnInit {
  @Input() user : Users;


  constructor() { }

  ngOnInit(): void {
  }

}
