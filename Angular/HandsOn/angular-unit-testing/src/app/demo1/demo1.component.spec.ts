import { ComponentFixture, TestBed } from '@angular/core/testing';
import { Demo1Component } from './demo1.component';

describe('Demo1Component', () => {
  let component: Demo1Component;
  let fixture: ComponentFixture<Demo1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Demo1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Demo1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
  // test spec
  it('should return Hello World',()=>{
    //Arrange
    let expected='Hello World'
    //Act
    let actual=component.Greet();
    //Asseret
    expect(actual).toEqual(expected)
  });
  it('Should return Hello Sachin',()=>{
    let actual=component.Note('Sachin');
    expect(actual).toEqual("Hi,Sachin");
      
  });
  it('Count should be 4',()=>{
    let count=component.GetFlowers().length;
    expect(count).toBeGreaterThan(0);
  });
  it('Suould match Rose',()=>{
    let flowers=component.GetFlowers();
    expect(flowers).toContain("Rose");
  });
  it('Should return true',()=>{
    let result=component.IsEven(20);
    expect(result).toBeTruthy();
  });
  it('Should return false',()=>{
    let result=component.IsEven(21);
    expect(result).toBeFalsy();
  });
});
