import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

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
    private router: Router,
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

    const formControl = this.addCandidateForm.controls;

    const candidate = new Candidate();

    candidate.Nome = formControl.Nome.value;
    candidate.Telefone = formControl.Telefone.value;
    candidate.UrlLinkedin = formControl.UrlLinkedin.value;
    candidate.UsuarioGithub = formControl.UsuarioGithub.value;

    this.sCandidate.saveCandidate(candidate)
      .subscribe(
        data => {
          alert('Cadastrado com sucesso!');
          setTimeout(() => {
            this.router.navigate(['/']);
          }, 500);
        },
        errors => { }
      )
  }

  createForm(candidate: Candidate): void {
    this.addCandidateForm = new FormGroup({
      Nome: new FormControl(candidate.Nome),
      Telefone: new FormControl(candidate.Telefone),
      UrlLinkedin: new FormControl(candidate.UrlLinkedin),
      UsuarioGithub: new FormControl(candidate.UsuarioGithub),
    });
  }
}
