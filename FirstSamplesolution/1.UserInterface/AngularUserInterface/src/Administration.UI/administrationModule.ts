import { NgModule } from '@angular/core';
//import { PersonsPage } from './Persons/Components/personsPage';
import { ProfessionsPage } from './Professions/Components/professionsPage';
import { ProfessionsGrid } from './Professions/Components/professionsGrid';

//export * from './Persons/Components/personsPage';
export * from './Professions/Components/professionsPage';

@NgModule({
  declarations: [
    ProfessionsGrid,
    ProfessionsPage
  ],
  exports: [
    ProfessionsGrid,
    ProfessionsPage
  ]

})

export class AdministrtionModule {

}