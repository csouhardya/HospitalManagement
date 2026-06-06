import { Component } from '@angular/core';
import { AuthService } from '../../services/auth.service';

@Component({
 selector: 'app-login',
 templateUrl: './login.component.html'
})
export class LoginComponent {
  userName = '';
  password = '';
  error = '';

  constructor(private auth: AuthService) {}

  login() {
    this.error = '';
    this.auth.login(this.userName, this.password);
  }
}