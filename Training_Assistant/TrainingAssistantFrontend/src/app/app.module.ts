import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MusclePartComponent } from './muscle-part/muscle-part.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ExerciseComponent } from './exercise/exercise.component';
import { TrainingComponent } from './training/training.component';
import { TrainingPlanComponent } from './training-plan/training-plan.component';
import { UserComponent } from './user/user.component';
import { BanerComponent } from './baner/baner.component';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    MusclePartComponent,
    ExerciseComponent,
    TrainingComponent,
    TrainingPlanComponent,
    UserComponent,
    BanerComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
