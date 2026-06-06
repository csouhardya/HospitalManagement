import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../constants/environment';

@Component({
 selector: 'app-billing',
 templateUrl: './billing.component.html'
})
export class BillingComponent {
  bill: any = {
    patientId: '',
    discountAmount: 0,
    taxAmount: 0,
    items: []
  };

  item: any = {
    itemName: '',
    quantity: 1,
    rate: 0
  };

  api = environment.apiUrl;

  constructor(private http: HttpClient) {}

  addItem() {
    this.bill.items.push(this.item);
  }

  total() {
    return this.bill.items.reduce((sum: number, x: any) =>
      sum + (x.quantity * x.rate), 0) - this.bill.discountAmount;
  }

  save() {
    this.bill.totalAmount = this.total();

    this.http.post(this.api + '/billing', this.bill)
      .subscribe(res => alert('Bill saved'));
  }
}