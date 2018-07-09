import {
	Component,
	ViewChild,
	EventEmitter,
	Input,
	Output
} from '@angular/core';
import { ProfessionsProxy } from '../Services/professionsProxy';
@Component({
	selector: 'professions-grid',
	templateUrl: './professionsGrid.html',
	styleUrls: ['./professionsGrid.scss']
})
export class ProfessionsGrid{
	protected _professionsProxy: ProfessionsProxy;
	
	constructor(proxy) {
		this._professionsProxy= new ProfessionsProxy(proxy);
	}

}
