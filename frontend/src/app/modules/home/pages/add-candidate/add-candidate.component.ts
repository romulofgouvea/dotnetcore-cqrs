import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

//#region Services
import { CandidateService } from './../../../../core/services/candidate.service';
//#endregion

//#region Models
import { MCandidate } from '../../../../shared/models/MCandidate';
import { MUserGithub } from '../../../../shared/models/MUserGithub';
//#endregion

@Component({
  selector: 'app-add-candidate',
  templateUrl: './add-candidate.component.html',
  styleUrls: ['./add-candidate.component.scss']
})
export class AddCandidateComponent implements OnInit {

  addCandidateForm: FormGroup;
  userGithub: MUserGithub;

  constructor(
    private router: Router,
    private sCandidate: CandidateService,
  ) {
    this.createForm(new MCandidate());
  }

  ngOnInit(): void {

  }

  findUserGithub($event: any): void {
    const userGithub: string = ($event.target as HTMLInputElement).value;

    this.sCandidate
      .findDataRepositoryGithub(userGithub)
      .subscribe(
        (data: MUserGithub) => {
          this.userGithub = data;
        },
        errors => { }
      );

  }

  handleClickSave(): void {

    const formControl = this.addCandidateForm.controls;

    const candidate = new MCandidate();

    candidate.nome = formControl.Nome.value;
    candidate.telefone = formControl.Telefone.value;
    candidate.urlLinkedin = formControl.UrlLinkedin.value;
    candidate.usuarioGithub = formControl.UsuarioGithub.value;

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

  createForm(candidate: MCandidate): void {
    this.addCandidateForm = new FormGroup({
      Nome: new FormControl(candidate.nome),
      Telefone: new FormControl(candidate.telefone),
      UrlLinkedin: new FormControl(candidate.urlLinkedin),
      UsuarioGithub: new FormControl(candidate.usuarioGithub),
    });
  }
}
