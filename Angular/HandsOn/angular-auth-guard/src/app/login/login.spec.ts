import { ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { AuthService } from '../auth-service';

import { Login } from './login';

describe('Login', () => {
  let component: Login;
  let fixture: ComponentFixture<Login>;
  let authServiceSpy: jasmine.SpyObj<AuthService>;
  let routerSpy: jasmine.SpyObj<Router>;

  beforeEach(async () => {
    authServiceSpy = jasmine.createSpyObj<AuthService>('AuthService', ['login']);
    routerSpy = jasmine.createSpyObj<Router>('Router', ['navigate']);

    await TestBed.configureTestingModule({
      imports: [Login],
      providers: [
        { provide: AuthService, useValue: authServiceSpy },
        { provide: Router, useValue: routerSpy }
      ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Login);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should navigate to dashboard on successful login', () => {
    component.username = 'admin';
    component.password = 'admin123';
    authServiceSpy.login.and.returnValue(true);

    component.onLogin();

    expect(authServiceSpy.login).toHaveBeenCalledWith('admin', 'admin123');
    expect(routerSpy.navigate).toHaveBeenCalledWith(['/dashboard']);
    expect(component.errorMessage).toBe('');
  });

  it('should show error message on failed login', () => {
    component.username = 'wrong-user';
    component.password = 'wrong-password';
    authServiceSpy.login.and.returnValue(false);

    component.onLogin();

    expect(authServiceSpy.login).toHaveBeenCalledWith('wrong-user', 'wrong-password');
    expect(routerSpy.navigate).not.toHaveBeenCalled();
    expect(component.errorMessage).toBe('Invalid credentials');
  });

  it('should disable submit button when form is invalid', async () => {
    fixture.detectChanges();
    await fixture.whenStable();

    const submitButton: HTMLButtonElement = fixture.debugElement.query(
      By.css('button[type="submit"]')
    ).nativeElement;

    expect(submitButton.disabled).toBeTrue();
  });

  it('should enable submit button when form is valid', async () => {
    const usernameInput: HTMLInputElement = fixture.debugElement.query(
      By.css('input[name="username"]')
    ).nativeElement;
    const passwordInput: HTMLInputElement = fixture.debugElement.query(
      By.css('input[name="password"]')
    ).nativeElement;

    usernameInput.value = 'admin';
    usernameInput.dispatchEvent(new Event('input'));
    passwordInput.value = 'admin123';
    passwordInput.dispatchEvent(new Event('input'));

    fixture.detectChanges();
    await fixture.whenStable();
    fixture.detectChanges();

    const submitButton: HTMLButtonElement = fixture.debugElement.query(
      By.css('button[type="submit"]')
    ).nativeElement;

    expect(submitButton.disabled).toBeFalse();
  });
});
