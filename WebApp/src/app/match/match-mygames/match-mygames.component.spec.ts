import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MatchMygamesComponent } from './match-mygames.component';

describe('MatchMygamesComponent', () => {
  let component: MatchMygamesComponent;
  let fixture: ComponentFixture<MatchMygamesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MatchMygamesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MatchMygamesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
