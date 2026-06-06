import { Component, OnInit } from '@angular/core';
import { PatientService } from '../../services/patient.service';

@Component({
 selector: 'app-patient-list',
 templateUrl: './patient-list.component.html'
})
export class PatientListComponent implements OnInit {
  patients: any[] = [];
  filteredPatients: any[] = [];
  searchText = '';
  loading = false;

  constructor(private patientService: PatientService) {}

  ngOnInit(): void {
    this.load();

    this.load();
  }

  load() {
    this.loading = true;

    this.patientService.getPatients().subscribe(res => {
      this.patients = res;
      this.filteredPatients = res;
      this.loading = false;
    });
  }

  search() {
    if(this.searchText.length == 0) {
      this.filteredPatients = this.patients;
      return;
    }

    this.patientService.search(this.searchText).subscribe(res => {
      this.filteredPatients = res;
    });
  }

  deletePatient(id: number) {
    if(confirm('Delete patient?')) {
      this.patientService.delete(id).subscribe(() => {
        this.load();
      });
    }
  }
}