import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {UserService} from "../../../service/user.service";

@Component({
  selector: 'app-guest',
  templateUrl: './guest.component.html',
  styleUrls: ['./guest.component.css']
})
export class GuestComponent implements OnInit {

  constructor(private userService: UserService, private router: Router) { }

  logout(){
    this.userService.logout()
  }

  ngOnInit(): void {
    this.router.navigate(['accommodation']);

  }


  public home(){
    this.router.navigate(['accommodation']);
  }
}
