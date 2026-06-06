import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../constants/environment';

@Component({
 selector: 'app-book-appointment',
 templateUrl: './book-appointment.component.html'
})
export class BookAppointmentComponent {
  model: any = {
    patientId: '',
    doctorId: '',
    slot: '',
    reason: ''
  };

  api = environment.apiUrl;

  constructor(private http: HttpClient) {}

  book() {
    this.http.post(this.api + '/appointment/book', this.model)
      .subscribe(res => {
        alert('Booked');
      }, err => {
        alert('Failed');
      });
  }
}