import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import { PersonsPage, ProfessionsPage, AdministrtionModule } from '../Administration.UI/administrationModule';
import { CommonModule } from '@angular/common';
import { PersonsGrid } from 'src/Administration.UI/Persons/Components/personsGrid';
import { ProfessionsGrid } from 'src/Administration.UI/Professions/Components/professionsGrid';
import { CreatePerson } from 'src/Administration.UI/Persons/Components/createPerson';
import { createProfession } from 'src/Administration.UI/Professions/Components/createProfession';

export const routes: Routes = [
	{path: 'administration/PersonsGrid', component: PersonsGrid},
	{path: 'administration/CreatePerson', component: CreatePerson},
	{path: 'administration/ProfessionsGrid', component: ProfessionsGrid}
	{path: 'administration/CreateProfession', component: createProfession}
];

@NgModule({
	imports: [
		RouterModule.forRoot(routes),
	],
	exports:[RouterModule]
})
export class AngularUserInterfaceRouting {
}
