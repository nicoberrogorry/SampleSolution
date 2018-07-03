import {
	Component,
	ViewChild,
	EventEmitter,
	Input,
	Output
} from '@angular/core';

@Component({
	selector: 'persons-Page',
	templateUrl: './personsPage.html',
	styleUrls: ['.personsPage.scss']
})

export class PersonsPage{
	//	@ViewChild("stepSelector")
	public currentStep: Number;

	constructor() {
		this.currentStep = 1;
	}
}