import { Component, ViewChild, EventEmitter, Input, Output, Inject, OnInit} from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ProfessionsService } from '../Services/professionsService';
import { GetProfessionsSummaryRequest } from '../Request/GetProfessionsSummaryRequest';

import { Profession } from '../Classes/Profession';

@Component({
	selector: 'professions-grid',
	templateUrl: './professionsGrid.html',
	styleUrls: ['./professionsGrid.scss'],
  providers: [ProfessionsService]
})

export class ProfessionsGrid implements OnInit {
  protected _professionsService: ProfessionsService;
  protected _professionsArray: Profession[];

	constructor(professionsService: ProfessionsService) {
    this._professionsService = professionsService;
  }

  ngOnInit(){
    let promise = this._professionsService.getProfessionsSummary(GetProfessionsSummaryRequest).pipe(
      map(getProfessionsSummaryResponse => getProfessionsSummaryResponse.ProfessionsArray)
    ).subscribe(
      professionsArray => {
        this._professionsArray = professionsArray;
        console.log("ProfessionsGrid recieved: ", this._professionsArray);
      }
    );
  }
}
