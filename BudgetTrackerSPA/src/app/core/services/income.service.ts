import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Incomes } from 'src/app/shared/models/incomes';

@Injectable({
  providedIn: 'root'
})
export class IncomeService {

  constructor(private apiService : ApiService) { }

  addIncome(income : Incomes) {
    return this.apiService.create('income/add', income);
  }
}
