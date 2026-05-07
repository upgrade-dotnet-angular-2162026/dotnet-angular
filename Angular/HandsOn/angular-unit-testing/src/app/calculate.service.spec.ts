import { TestBed } from '@angular/core/testing';

import { CalculateService } from './calculate.service';

describe('CalculateService', () => {
  let service: CalculateService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CalculateService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
  it('should return 6',()=>{
    let actual=service.Add(2,4);
    expect(actual).toEqual(6);
  })
  it('should return 6',()=>{
    let actual=service.Mul(2,3);
    expect(actual).toEqual(6);
  })
  it('should return 6',()=>{
    let actual=service.Div(12,2);
    expect(actual).toEqual(6);
  })
  it('should retrun 2',()=>{
    let actual=service.Sub(4,2);
    expect(actual).toEqual(2);
  })
});
