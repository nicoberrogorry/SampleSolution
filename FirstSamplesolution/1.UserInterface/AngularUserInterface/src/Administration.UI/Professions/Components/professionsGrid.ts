import { Component, ViewChild, EventEmitter, Input, Output, Inject, OnInit} from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ProfessionsService } from '../Services/professionsService';
import { GetProfessionsSummaryRequest } from '../Request/GetProfessionsSummaryRequest';

import { ProfessionSummary } from '../Classes/ProfessionSummary';

@Component({
	selector: 'professions-grid',
	templateUrl: './professionsGrid.html',
	styleUrls: ['./professionsGrid.scss'],
  providers: [ProfessionsService]
})

export class ProfessionsGrid implements OnInit {
  protected _professionsService: ProfessionsService;
  protected _professionsSummary: ProfessionSummary[];

	constructor(professionsService: ProfessionsService) {
    this._professionsService = professionsService;
  }

  ngOnInit(){
    this._professionsService.getProfessionsSummary(GetProfessionsSummaryRequest).then(result => {
      this._professionsSummary = result.ProfessionsSummary;
      console.log("ProfessionsGrid._professionsSummary was asigned to: " + result);
      console.log("ProfessionsGrid Promise resolved to: " + JSON.stringify(result));
    });
  }
}
