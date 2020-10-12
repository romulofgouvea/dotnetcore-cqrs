import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, pipe } from 'rxjs';

import { APP_CONFIG, IAppConfig } from './../config/app.config';

//#region Models
import { MCandidate } from '../../shared/models/MCandidate';
import { MUserGithub } from '../../shared/models/MUserGithub';
//#endregion

@Injectable({
  providedIn: 'root'
})
export class CandidateService {

  constructor(
    @Inject(APP_CONFIG) private config: IAppConfig,
    private http: HttpClient
  ) { }

  findDataRepositoryGithub(userGithub: string): Observable<MUserGithub> {
    return this.http.get(`https://api.github.com/users/${userGithub}`);
  }

  saveCandidate(candidate: MCandidate): Observable<MCandidate> {
    return this.http.post<any>(`${this.config.base_url}/v1/candidate/create`, candidate);
  }

  readAllCandidate(): Observable<MCandidate[]>{
    return this.http.get<MCandidate[]>(`${this.config.base_url}/v1/candidate/read`);
  }
}
