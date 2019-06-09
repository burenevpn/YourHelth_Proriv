import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReceptionFormComponent } from './reception-form.component';

describe('ReceptionFormComponent', () => {
  let component: ReceptionFormComponent;
  let fixture: ComponentFixture<ReceptionFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReceptionFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReceptionFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
