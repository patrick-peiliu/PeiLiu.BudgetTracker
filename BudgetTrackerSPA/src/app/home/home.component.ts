import { UserService } from './../core/services/user.service';
import { Users } from './../shared/models/users';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  users: Users[];

  constructor(private userService : UserService) { }

  ngOnInit(): void {
    this.userService.getAllUsers()
    .subscribe( u => {
      this.users = u;
    })
  }

}
