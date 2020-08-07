import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, FormControl, Validators } from '@angular/forms';


@Component({
  selector: 'app-add-expenditures',
  templateUrl: './add-expenditures.component.html',
  styleUrls: ['./add-expenditures.component.css']
})
export class AddExpendituresComponent implements OnInit {

  createExpendituresForm: FormGroup;

  constructor(private fb: FormBuilder) {
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
  }

}
