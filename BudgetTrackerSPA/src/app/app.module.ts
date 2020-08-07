import { JwtModule } from '@auth0/angular-jwt';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

// 3rd party libraries
import {
  NgbCarouselModule,
  NgbCollapseModule,
  NgbDropdownModule,
  NgbModalModule,
  NgbPaginationModule,
  NgbTabsetModule,
  NgbAlertModule
} from "@ng-bootstrap/ng-bootstrap";

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';

import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { UserListComponent } from './users/user-list/user-list.component';
import { UserTableComponent } from './shared/components/user-table/user-table.component';
import { AddUserComponent } from './users/add-user/add-user.component';
import { UserDetailsComponent } from './users/user-details/user-details.component';
import { AddIncomeComponent } from './incomes/add-income/add-income.component';
import { AddExpendituresComponent } from './expenditures/add-expenditures/add-expenditures.component';


// Decorators -- like attributes in C#
// four properties
@NgModule({
  // Components, if you wanna use a Component in Angular
  // they should be declared inside at least one module
  declarations: [
    AppComponent,
    HomeComponent,
    UserListComponent,
    UserTableComponent,
    AddUserComponent,
    UserDetailsComponent,
    AddIncomeComponent,
    AddExpendituresComponent,
  ],
  
  // third party
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgbModule,
    NgbCarouselModule,
    NgbCollapseModule,
    NgbDropdownModule,
    NgbModalModule,
    NgbPaginationModule,
    NgbTabsetModule,
    NgbAlertModule,
    FormsModule, 
    ReactiveFormsModule,
  ],

  // dependency injection
  providers: [],

  // we can select which component needs to be started when app starts
  // main --> AppModule --> bootstrap AppComponent
  bootstrap: [AppComponent]
})

// it's a typescript class
export class AppModule { } 


/*
we need to make Ajax calls from Angular to API to get data.
XmlHttpRequest
HttpClient -> it will use  XmlHttpRequest behind the scenes (Xhr)
ASP.NET  --> Controller (MVC and API) --> Services (class libraries, base repository) --> Repositories(Class libraries) --> Database
We usually sperate our Angular application code in to different feature folders to organize and reuse our code properly
http:locahost:4200/movies/2 --> MovieDetailsComponent
Angular --> Components --> Services - HttpClient -> API (JSON)
 --> Services will give that to Components and components will return model to the views, so that views can display that data


We create a base API service that will have common CRUD operations
so that specific services, MovieServices, GenreService etc can talk to
API service that will talk to our REST API

A service is a ts class that has @Injectable decorator,
we can use it with DI
*/