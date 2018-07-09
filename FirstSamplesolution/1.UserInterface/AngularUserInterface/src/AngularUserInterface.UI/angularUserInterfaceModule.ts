import { BrowserModule } from '@angular/platform-browser';
import { NgModule, ModuleWithProviders } from '@angular/core';


import { AdministrtionModule } from '../Administration.UI/administrationModule';
import { AngularUserInterfaceRouting } from './angularUserInterfaceRouting';
import { AngularUserInterface } from './angularUserInterface';
import { Navigator } from './Navigation/navigator';

@NgModule({
  declarations: [
    AngularUserInterface,
    Navigator  
  ],
  imports: [
    BrowserModule,
    AdministrtionModule,
    AngularUserInterfaceRouting
  ],
  providers: [],
  bootstrap: [AngularUserInterface]
})

export class AngularUserInterfaceModule{
  static forRoot(): ModuleWithProviders {
		return {
      ngModule: AngularUserInterfaceModule
    }
  }
}