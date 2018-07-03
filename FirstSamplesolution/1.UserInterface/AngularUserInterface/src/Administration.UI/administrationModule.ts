import { NgModule } from '@angular/core';
import { ProfessionsGrid } from './Professions/Components/professionsGrid';

// Components
export * from '../Administration.UI/Professions/Components/professionsGrid';

@NgModule({
    exports: [ProfessionsGrid]
})
export class AdministrtionModule{
}