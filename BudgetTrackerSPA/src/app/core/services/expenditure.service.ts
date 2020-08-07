import { Expenditures } from './../../shared/models/expenditures';
import { Injectable } from '@angular/core';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})

export class ExpenditureService {

  constructor(private apiService : ApiService) { }

  addExpenditure(expenditure : Expenditures) {
    return this.apiService.create('expenditure/add', expenditure);
  }
}
