import { MUserGithub } from '../../../../shared/models/MUserGithub';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-github-info',
  templateUrl: './github-info.component.html',
  styleUrls: ['./github-info.component.scss']
})
export class GithubInfoComponent implements OnInit {

  @Input() userGithub: MUserGithub;

  constructor() { }

  ngOnInit(): void {
  }

}
