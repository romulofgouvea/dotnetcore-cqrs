import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

//#region Services
import { CandidateService } from './../../../../core/services/candidate.service';
//#endregion

//#region Models
import { Candidate } from './../../../../shared/models/Candidate';
import { UserGithub } from './../../../../shared/models/UserGithub';
//#endregion

@Component({
  selector: 'app-add-candidate',
  templateUrl: './add-candidate.component.html',
  styleUrls: ['./add-candidate.component.scss']
})
export class AddCandidateComponent implements OnInit {

  addCandidateForm: FormGroup;
  userGithub: UserGithub;

  constructor(
    private sCandidate: CandidateService,
  ) {
    this.createForm(new Candidate());
  }

  ngOnInit(): void {

  }

  findUserGithub($event: any): void {
    const userGithub: string = ($event.target as HTMLInputElement).value;

    this.sCandidate
      .findDataRepositoryGithub(userGithub)
      .subscribe(
        (data: UserGithub) => {
          this.userGithub = data;
        },
        errors => { }
      );

  }

  handleClickSave(): void {
  }

  createForm(candidate: Candidate): void {
    this.addCandidateForm = new FormGroup({
      Nome: new FormControl(candidate.Nome),
      Telefone: new FormControl(candidate.Telefone),
      UrlLinkedin: new FormControl(candidate.UrlLinkedin),
      UsuarioGitHub: new FormControl(candidate.UsuarioGithub),
    });
  }
}
