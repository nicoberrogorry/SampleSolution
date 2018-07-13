import { NgModule } from '@angular/core';

import { RestClient, WebConfig } from '../General/generalModule';

import { PersonsGrid } from './Persons/Components/personsGrid';
import { CreatePerson } from './Persons/Components/createPerson';
import { ProfessionsGrid } from './Professions/Components/professionsGrid';
import { CreateProfession } from './Professions/Components/createProfession';

export * from './Persons/Components/personsGrid';
export * from './Persons/Components/createPerson';
export * from './Professions/Components/professionsGrid';
export * from './Professions/Components/createProfession';
export * from './Professions/Services/professionsService';

@NgModule({
  declarations: [
    PersonsGrid,
    CreatePerson,
    ProfessionsGrid,
    CreateProfession
  ],
  exports: [
    PersonsGrid,
    CreatePerson,
    ProfessionsGrid,
    CreateProfession
  ],
  providers: [
    RestClient,
    WebConfig
  ]
})
export class AdministrtionModule {}
