import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AngularUserInterface } from './angularUserInterface';
import { Navigator } from './Navigation/navigator';

@NgModule({
  declarations: [
    AngularUserInterface,
    Navigator  
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AngularUserInterface]
})

export class AngularUserInterfaceModule{}