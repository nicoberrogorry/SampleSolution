import { CommonModule } from '@angular/common';

import { RestClient, WebConfig } from '../General/generalModule';

import { PersonsGrid } from './Persons/Components/personsGrid';
import { CreatePerson } from './Persons/Components/createPerson';
import { ProfessionsGrid } from './Professions/Components/professionsGrid';
import { CreateProfession } from './Professions/Components/createProfession';
import { NgModule } from '@angular/core';
import { ProfessionsService } from './Professions/Services/professionsService';

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
  imports: [
    CommonModule
  ],
  exports: [
    PersonsGrid,
    CreatePerson,
    ProfessionsGrid,
    CreateProfession
  ],
  providers: [
    WebConfig,
    RestClient
  ]
})

export class AdministrtionModule {}
