import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { ScheduleComponent } from './Schedule/schedule.component';
import { HomeComponent } from './Home/home.component';

const appRoutes: Routes = [
   { path: 'Home', component: HomeComponent },
   { path: 'Schedule', component: ScheduleComponent}
];


@NgModule({
  declarations: [
    AppComponent, ScheduleComponent, HomeComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
