import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { LoginComponent } from './components/login/login.component';
import { PatientListComponent } from './components/patient-list/patient-list.component';
import { PatientDetailsComponent } from './components/patient-details/patient-details.component';
import { CreatePatientComponent } from './components/create-patient/create-patient.component';
import { BookAppointmentComponent } from './components/book-appointment/book-appointment.component';
import { BillingComponent } from './components/billing/billing.component';
import { AuthGuard } from './guards/auth.guard';

const routes: Routes = [
  { path: '', component: DashboardComponent },
  { path: 'login', component: LoginComponent },
  { path: 'patients', component: PatientListComponent, canActivate: [AuthGuard] },
  { path: 'patients/create', component: CreatePatientComponent },
  { path: 'patients/:id', component: PatientDetailsComponent },
  { path: 'appointments/book', component: BookAppointmentComponent },
  { path: 'billing', component: BillingComponent },
  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
