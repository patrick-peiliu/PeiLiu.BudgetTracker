import { Users } from './../../shared/models/users';
import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private apiService : ApiService) { }

  getAllUsers() : Observable<Users[]> {
    return this.apiService.getAll('user');
  }

  addUser(user : Users) {
    return this.apiService.create('user/add', user);
  }

  getUserDetails(id: number) : Observable<Users>{
    return this.apiService.getOne(`${'user'}`, id);
  }
}
