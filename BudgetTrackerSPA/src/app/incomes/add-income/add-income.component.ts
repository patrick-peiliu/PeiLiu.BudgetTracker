import { IncomeService } from './../../core/services/income.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, FormControl, Validators } from '@angular/forms';
import { Incomes } from 'src/app/shared/models/incomes';

@Component({
  selector: 'app-add-income',
  templateUrl: './add-income.component.html',
  styleUrls: ['./add-income.component.css']
})
export class AddIncomeComponent implements OnInit {
  income = {} as Incomes;

  createIncomeForm: FormGroup;

  constructor(private fb: FormBuilder, private incomeService:IncomeService) {
    this.createIncomeForm = new FormGroup({
      userId: new FormControl(''),
      amount: new FormControl(''),
      description: new FormControl(''),
    });
  }

  get f() { return this.createIncomeForm.controls; }

  buildForm() {
    this.createIncomeForm = this.fb.group({
      userId: ['', Validators.required],
      amount: [null, Validators.required],
      description: ['', Validators.required],
    });
  }

  ngOnInit(): void {
    this.buildForm();
  }

  onSubmit() {
    console.log(this.createIncomeForm);
    this.income = this.createIncomeForm.value;

    this.incomeService.addIncome(this.income).subscribe(
      res => {
        console.log(res);
      }
    )
  }

}
