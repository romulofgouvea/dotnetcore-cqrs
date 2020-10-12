import { UserGithub } from './../../shared/models/UserGithub';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CandidateService {

  constructor(private http: HttpClient) { }

  findDataRepositoryGithub(userGithub: string): Observable<UserGithub> {
    return this.http.get(`https://api.github.com/users/${userGithub}`);
  }
}
