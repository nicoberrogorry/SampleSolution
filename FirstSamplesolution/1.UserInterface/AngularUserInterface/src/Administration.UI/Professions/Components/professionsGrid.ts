import { Component, ViewChild, EventEmitter, Input, Output} from '@angular/core';

import { ProfessionsService } from '../Services/professionsService';
import { GetProfessionsSummaryRequest } from '../Request/GetProfessionsSummaryRequest';

@Component({
	selector: 'professions-grid',
	templateUrl: './professionsGrid.html',
	styleUrls: ['./professionsGrid.scss'],
  providers: [ProfessionsService]
})

export class ProfessionsGrid{
  protected _professionsService: ProfessionsService;

	constructor(professionsService: ProfessionsService) {
    this._professionsService = professionsService;
    console.log(professionsService.getProfessionsSummary(GetProfessionsSummaryRequest));
  }
}
