import { Component, OnInit } from '@angular/core';

import { CandidateService } from 'src/app/core/services/candidate.service';
import { MCandidate } from 'src/app/shared/models/MCandidate';

@Component({
  selector: 'app-list-candidate',
  templateUrl: './list-candidate.component.html',
  styleUrls: ['./list-candidate.component.scss']
})
export class ListCandidateComponent implements OnInit {

  candidates: MCandidate[];

  constructor(
    private sCandidate: CandidateService,
  ) { }

  ngOnInit(): void {
    this.readAllCandidate();
  }

  readAllCandidate(): void {
    this.sCandidate.readAllCandidate()
      .subscribe(
        data => {
          this.candidates = data;
          console.log(data);
        },
        errors => { }
      )

  }
}
