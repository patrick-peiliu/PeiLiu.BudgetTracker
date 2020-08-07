import { ExpenditureService } from './../../core/services/expenditure.service';
import { Expenditures } from './../../shared/models/expenditures';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, FormControl, Validators } from '@angular/forms';


@Component({
  selector: 'app-add-expenditures',
  templateUrl: './add-expenditures.component.html',
  styleUrls: ['./add-expenditures.component.css']
})
export class AddExpendituresComponent implements OnInit {
  expenditure = {} as Expenditures;

  createExpendituresForm: FormGroup;

  constructor(private fb: FormBuilder, private expenditureService : ExpenditureService) {
    this.createExpendituresForm = new FormGroup({
      userId: new FormControl(''),
      amount: new FormControl(''),
      description: new FormControl(''),
    });
  }

  get f() { return this.createExpendituresForm.controls; }

  buildForm() {
    this.createExpendituresForm = this.fb.group({
      userId: ['', Validators.required],
      amount: [null, Validators.required],
      description: ['', Validators.required],
    });
  }

  ngOnInit(): void {
    this.buildForm();
  }

  onSubmit() {
    console.log(this.createExpendituresForm);
    this.expenditure = this.createExpendituresForm.value;

    this.expenditureService.addExpenditure(this.expenditure).subscribe(
      res => {
        console.log(res);
      }
    )

    // this.expenditureService.addExpenditure(this.expenditure).subscribe(
    //   res => {
    //     console.log(res);
    //   }
    // )
  }

}
