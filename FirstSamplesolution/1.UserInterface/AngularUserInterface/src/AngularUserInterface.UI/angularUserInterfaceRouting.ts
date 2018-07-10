import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import { PersonsGrid, CreatePerson, ProfessionsGrid,
	CreateProfession, AdministrtionModule } from '../Administration.UI/administrationModule';
import { CommonModule } from '@angular/common';
import { WelcomePage } from './Extra/welcomePage'

export const routes: Routes = [
	{path: '', component: WelcomePage},
	{path: 'Administration/PersonsGrid', component: PersonsGrid},
	{path: 'Administration/CreatePerson', component: CreatePerson},
	{path: 'Administration/ProfessionsGrid', component: ProfessionsGrid},
	{path: 'Administration/CreateProfession', component: CreateProfession}
];

@NgModule({
	imports: [
		RouterModule.forRoot(routes),
	],
	exports:[RouterModule]
})

export class AngularUserInterfaceRouting {
}
