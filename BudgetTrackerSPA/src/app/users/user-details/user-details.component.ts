import { Component, OnInit } from '@angular/core';
import { Users } from 'src/app/shared/models/users';
import { ActivatedRoute, Router } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';

@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.css']
})
export class UserDetailsComponent implements OnInit {
  user : Users;
  id : number;

  constructor(private userService: UserService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {

    this.route.paramMap.subscribe(
      params => {
        this.id = +params.get('id');
        this.getUserDetails();
      }
    );
  }

  private getUserDetails() {
    this.userService.getUserDetails(this.id)
      .subscribe(m => {
        this.user = m;
      });
  }

}
