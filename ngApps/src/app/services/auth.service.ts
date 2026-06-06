import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { environment } from '../constants/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  api = environment.apiUrl;

  constructor(private http: HttpClient, private router: Router) { }

  login(userName: string, password: string) {
    return this.http.post<any>(this.api + '/auth/login', {
      userName: userName,
      password: password
    }).subscribe(res => {
      localStorage.setItem('token', res.token);
      localStorage.setItem('role', 'Admin');
      this.router.navigate(['/']);
    });
  }

  isLoggedIn(): boolean {
    return localStorage.getItem('token') != null;
  }

  logout() {
    localStorage.clear();
    this.router.navigate(['/login']);
  }
}