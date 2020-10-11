import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

//#region Components
import { AddCandidateComponent } from './pages/add-candidate/add-candidate.component';
import { ListCandidateComponent } from './pages/list-candidate/list-candidate.component';
//#endregion

const routes: Routes = [
  { path: 'add-candidate', component: AddCandidateComponent },
  { path: '', component: ListCandidateComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
