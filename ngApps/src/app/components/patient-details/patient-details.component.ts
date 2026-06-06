import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PatientService } from '../../services/patient.service';

@Component({
 selector: 'app-patient-details',
 templateUrl: './patient-details.component.html'
})
export class PatientDetailsComponent implements OnInit {
  patient: any;
  id: any;

  constructor(
    private route: ActivatedRoute,
    private patientService: PatientService) {}

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.id = params['id'];

      this.patientService.getPatient(this.id).subscribe(res => {
        this.patient = res;
      });
    });
  }
}