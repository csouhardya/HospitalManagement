import { Component, OnInit, Inject, PLATFORM_ID } from '@angular/core';
import { isPlatformBrowser } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../constants/environment';

@Component({
 selector: 'app-dashboard',
 templateUrl: './dashboard.component.html'
})
export class DashboardComponent implements OnInit {
  data: any;
  api = environment.apiUrl;

  constructor(
    private http: HttpClient,
    @Inject(PLATFORM_ID) private platformId: object
  ) {}

  ngOnInit(): void {
    if (isPlatformBrowser(this.platformId)) {
      setInterval(() => {
        this.load();
      }, 5000);

      this.load();
    }
  }

  load() {
    this.http.get(this.api + '/reports/dashboard')
      .subscribe(res => {
        this.data = res;
      });
  }
}