import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from 'src/app/service/user.service';
import { LoginData } from '../../hospital/model/login-data.model';
import  jwtDecode from 'jwt-decode';
import { User } from '../../hospital/model/user.model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private userService: UserService, private router: Router) { }

  public currentUser: User = new User();

  public data: LoginData = new LoginData();

  accessToken : any;

  ngOnInit(): void {

  }

  public login() {
    this.data.id = '';
    this.data.username = '';
    this.data.name = '';
    this.data.lastname = '';
    this.data.role = '';
    this.data.placeOfLiving = '';
    this.currentUser.email = this.data.Email;
    this.currentUser.password = this.data.Password;
    this.userService.login(this.data).subscribe(res => {
      this.accessToken = res;
      this.userService.getCurrentUser().subscribe(user => {
          this.currentUser = user;
          console.log(this.currentUser);
              this.router.navigate(['/register/user']);
            
        });
    });
  }
}
