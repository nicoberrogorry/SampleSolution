import { NgModule } from '@angular/core';
//import { PersonsPage } from './Persons/Components/personsPage';
import { ProfessionsPage } from './Professions/Components/professionsPage';

//export * from './Persons/Components/personsPage';
export * from './Professions/Components/professionsPage';

@NgModule({
  declarations: [
    ProfessionsPage
  ],
  exports: [
    // PersonsPage,
    ProfessionsPage
  ]

})

export class AdministrtionModule {

}