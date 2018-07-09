import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import { ProfessionsPage, AdministrtionModule } from '../Administration.UI/administrationModule';
import { CommonModule } from '@angular/common';

export const routes: Routes = [
	{path: 'administration/Professions',component: ProfessionsPage},
];


@NgModule({
	imports: [
		RouterModule.forRoot(routes),
	],
	exports:[RouterModule]
})
export class AngularUserInterfaceRouting {
}
