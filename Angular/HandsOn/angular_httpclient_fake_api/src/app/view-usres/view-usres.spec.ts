import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewUsres } from './view-usres';

describe('ViewUsres', () => {
  let component: ViewUsres;
  let fixture: ComponentFixture<ViewUsres>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ViewUsres],
    }).compileComponents();

    fixture = TestBed.createComponent(ViewUsres);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
