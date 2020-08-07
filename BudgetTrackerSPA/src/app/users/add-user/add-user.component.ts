import { Observable } from 'rxjs';
import { UserService } from './../../core/services/user.service';
import { Component, OnInit } from '@angular/core';
import { Users } from 'src/app/shared/models/users';
import { FormBuilder, FormGroup, FormArray, FormControl, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})

export class AddUserComponent implements OnInit {
  user = {} as Users;
  users: Users[];

  createUserForm: FormGroup;

  constructor(private fb: FormBuilder, private userService: UserService
    , private route: ActivatedRoute, private router: Router) {
    this.createUserForm = new FormGroup({
      fullName: new FormControl(''),
      email: new FormControl(''),
      password: new FormControl(''),
    });
  }

  get f() { return this.createUserForm.controls; }

  buildForm() {
    this.createUserForm = this.fb.group({
      fullName: ['', Validators.required],
      email: [null, Validators.required],
      password: ['', Validators.required],
    });
  }

  ngOnInit(): void {
    this.buildForm();
  }

  onSubmit() {
    console.log(this.createUserForm);
    
    this.userService.addUser(this.user).
    subscribe(resp => {
      this.user = resp;
    });

  }
}
