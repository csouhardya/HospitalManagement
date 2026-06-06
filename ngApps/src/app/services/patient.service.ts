import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../constants/environment';

@Injectable({
 providedIn: 'root'
})
export class PatientService {
  api = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getPatients() {
    return this.http.get<any[]>(this.api + '/patient');
  }

  getPatient(id: any) {
    return this.http.get<any>(this.api + '/patient/' + id);
  }

  search(q: string) {
    return this.http.get<any[]>(this.api + '/patient/search?q=' + q);
  }

  create(patient: any) {
    return this.http.post(this.api + '/patient', patient);
  }

  delete(id: number) {
    return this.http.delete(this.api + '/patient/' + id);
  }
}