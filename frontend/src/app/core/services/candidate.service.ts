import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { APP_CONFIG, IAppConfig } from './../config/app.config';

//#region Models
import { Candidate } from './../../shared/models/Candidate';
import { UserGithub } from './../../shared/models/UserGithub';
//#endregion

@Injectable({
  providedIn: 'root'
})
export class CandidateService {

  constructor(
    @Inject(APP_CONFIG) private config: IAppConfig,
    private http: HttpClient
  ) { }

  findDataRepositoryGithub(userGithub: string): Observable<UserGithub> {
    return this.http.get(`https://api.github.com/users/${userGithub}`);
  }

  saveCandidate(candidate: Candidate): Observable<Candidate> {
    return this.http.post<any>(`${this.config.base_url}/v1/candidate/create`, candidate);
  }
}
