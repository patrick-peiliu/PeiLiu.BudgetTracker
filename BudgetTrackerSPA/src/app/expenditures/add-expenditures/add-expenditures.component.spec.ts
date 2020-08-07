import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddExpendituresComponent } from './add-expenditures.component';

describe('AddExpendituresComponent', () => {
  let component: AddExpendituresComponent;
  let fixture: ComponentFixture<AddExpendituresComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddExpendituresComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddExpendituresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
