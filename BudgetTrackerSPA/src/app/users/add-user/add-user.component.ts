import { UserService } from './../../core/services/user.service';
import { Component, OnInit } from '@angular/core';
import { Users } from 'src/app/shared/models/users';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})

export class AddUserComponent implements OnInit {
  user: Users;

  constructor(private userService: UserService) { }

  ngOnInit(): void {
  }

}
