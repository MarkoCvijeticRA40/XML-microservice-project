import { Component, OnInit } from '@angular/core';
import { User } from '../../hospital/model/user.model';
import { ReservationType } from 'src/app/model/reservation.type';
import { UserService } from 'src/app/service/user.service';
import { ReservationService } from 'src/app/service/reservation.service';
import { Router } from '@angular/router';
import { FormControl, Validators } from '@angular/forms';
import { Accommodation } from 'src/app/model/accommodation';
import { AccommodationService } from 'src/app/service/accommodation.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  public confirmationPass: string = '';

  public user: User = new User();
  public user2: User = new User();
  public role: any = null;
  public enabled : boolean = false;
  public id: any;
  public accommodations: Accommodation[] = [];

  constructor( private reservationService: ReservationService, private accommodationService: AccommodationService, private userService: UserService, private router: Router) { }


  ngOnInit() {

    this.loadUserData();
    this.id = this.userService.getCurrentUserId();

  }

  loadUserData() {
    this.userService.getCurrentUser().subscribe(user => {
    
     this.user = user;
     console.log(this.user);
     this.user.lastName = user.lastName
     this.user.password = '';
     this.role = user.role;
        this.enableDisableButton();
     
    });
  }


  enableDisableButton(){
    if (this.role == 'Guest') {
          this.reservationService.getUndealetedGuestReservedReservations(this.user.id).subscribe(res => {
              if(res.length == 0){
                this.enabled = true;
              }else{
                this.enabled = false;
              }
          });  
    }

    else if(this.role == 'Host') {
      this.reservationService.getCheckHost(this.user.id).subscribe(res => {
        if(res.length == 0){
          this.enabled = true;
        }else{
          this.enabled = false;
        }
    });  
    }



  }



  public editProfile() {
    if (this.isInputValid()) {
      console.log(this.user)
      if (this.isPassConfirmed()) {
        if (this.user.role === "Host" || this.user.role === "Guest") {
          console.log(this.user)
          this.userService.updateUser(this.user).subscribe(res => {
            alert("You have successfully updated!");
          })
        } else {
          alert("Invalid role selection!")
        }
      } else {
        alert("You did not confirm your password!");
      }
    } else {
      alert("You must fill in all fields!")
    }
  
  }

  public deleteProfile(){

    this.userService.deleteUser(this.user.id).subscribe(res => {
        alert("Vas nalog je obrisan !")
        if(this.user.role == "Host"){

          this.accommodations.forEach((element: any) => {
            var app = new Accommodation(element);
            this.accommodationService.deleteAccommodation(element.id).subscribe(res => {
              alert("Svi smestaji od obrisanog hosta su obrisani")
            })
            
          });

        }

        this.router.navigate(['/accommodations']);
    });


  }


  private isInputValid(): boolean {
    return this.user.username != ''
         && this.user.name != '' && this.user.lastName != '' && this.user.password != ''
         && this.user.email != '' && this.user.placeOfLiving != ''
  }

  private isPassConfirmed(): boolean {
    return this.user.password === this.confirmationPass;
  }

  emailFormControl = new FormControl('', [
    Validators.required,
    Validators.email,
  ]);

  requiredPasswordControl = new FormControl('', [
    Validators.required,
  ]);

  requiredNameControl = new FormControl('', [
    Validators.required,
  ]);

  requiredSurnameControl = new FormControl('', [
    Validators.required,
  ]);

  requiredConfirmationPasswordControl = new FormControl('', [
    Validators.required,
  ])

  requiredUsernameControl = new FormControl('', [
    Validators.required,
  ]);

  

  requiredPlaceOfLivingControl = new FormControl('', [
    Validators.required,
  ]);

}
