import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-income',
  templateUrl: './add-income.component.html',
  styleUrls: ['./add-income.component.css']
})
export class AddIncomeComponent implements OnInit {

  createIncomeForm: FormGroup;

  constructor(private fb: FormBuilder) {
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
  }

}
