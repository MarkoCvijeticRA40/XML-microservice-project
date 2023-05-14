import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChangeDateAccommodationComponent } from './change-date-accommodation.component';

describe('ChangeDateAccommodationComponent', () => {
  let component: ChangeDateAccommodationComponent;
  let fixture: ComponentFixture<ChangeDateAccommodationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChangeDateAccommodationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ChangeDateAccommodationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
