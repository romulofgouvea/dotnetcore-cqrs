import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GithubInfoComponent } from './github-info.component';

describe('GithubInfoComponent', () => {
  let component: GithubInfoComponent;
  let fixture: ComponentFixture<GithubInfoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GithubInfoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GithubInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
