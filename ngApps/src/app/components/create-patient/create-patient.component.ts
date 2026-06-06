import { Component } from '@angular/core';
import { PatientService } from '../../services/patient.service';
import { Router } from '@angular/router';

@Component({
 selector: 'app-create-patient',
 templateUrl: './create-patient.component.html'
})
export class CreatePatientComponent {
  patient: any = {
    name: '',
    dateOfBirth: '',
    gender: '',
    mobile: '',
    email: '',
    insuranceNumber: '',
    isEmergency: false
  };

  constructor(
    private patientService: PatientService,
    private router: Router) {}

  save() {
    this.patientService.create(this.patient).subscribe(res => {
      alert('Saved');
      this.router.navigate(['/patients']);
    }, err => {
      alert('Something went wrong');
    });
  }
}