import { AddUserComponent } from './users/add-user/add-user.component';
import { HomeComponent } from './home/home.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserDetailsComponent } from './users/user-details/user-details.component';
import { AddIncomeComponent } from './incomes/add-income/add-income.component';
import { AddExpendituresComponent } from './expenditures/add-expenditures/add-expenditures.component';

const routes: Routes = [
  {path:'', component: HomeComponent},
  {path:'addUser', component: AddUserComponent},
  {path:'user/:id', component: UserDetailsComponent},
  {path:'addIncome', component: AddIncomeComponent},
  {path:'addExpenditure', component: AddExpendituresComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
