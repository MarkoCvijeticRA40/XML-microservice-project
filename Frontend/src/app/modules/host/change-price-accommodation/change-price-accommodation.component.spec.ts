import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChangePriceAccommodationComponent } from './change-price-accommodation.component';

describe('ChangePriceAccommodationComponent', () => {
  let component: ChangePriceAccommodationComponent;
  let fixture: ComponentFixture<ChangePriceAccommodationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChangePriceAccommodationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ChangePriceAccommodationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
