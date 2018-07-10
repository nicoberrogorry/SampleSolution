import {
	Component,
	ViewChild,
	EventEmitter,
	Input,
	Output
} from '@angular/core';

import { ProfessionsService } from '../Services/professionsService';

@Component({
	selector: 'professions-grid',
	templateUrl: './professionsGrid.html',
	styleUrls: ['./professionsGrid.scss'],
	providers: [ProfessionsService],
})

export class ProfessionsGrid{
	protected _professionsService: ProfessionsService;
	
	constructor(protected professionsService: ProfessionsService) {
		this._professionsService=professionsService
	}

}
