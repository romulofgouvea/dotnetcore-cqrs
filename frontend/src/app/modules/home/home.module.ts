import { ListCandidateComponent } from './pages/list-candidate/list-candidate.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

import { HomeRoutingModule } from './home-routing.module';
import { AddCandidateComponent } from './pages/add-candidate/add-candidate.component';

import { DebounceDirective } from './../../shared/directives/debounce.directive';
import { GithubInfoComponent } from './components/github-info/github-info.component';

@NgModule({
  declarations: [
    AddCandidateComponent,
    ListCandidateComponent,
    DebounceDirective,
    GithubInfoComponent
  ],
  imports: [
    CommonModule,
    HomeRoutingModule,
    ReactiveFormsModule
  ]
})
export class HomeModule { }
