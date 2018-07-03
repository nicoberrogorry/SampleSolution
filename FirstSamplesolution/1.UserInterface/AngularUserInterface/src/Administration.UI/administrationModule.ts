import { NgModule } from '@angular/core';
import { PersonsPage } from './Persons/Components/personsPage';
import { ProfessionsPage } from './Professions/Components/professionsPage';

export * from '../Administration.UI/Persons/Components/personsPage';
export * from '../Administration.UI/Professions/Components/professionsPage';

@NgModule({
    exports: [
      PersonsPage,
      ProfessionsPage
    ]
})

export class AdministrtionModule{

}
