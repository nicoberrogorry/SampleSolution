import { NgModule } from '@angular/core';

import { RestClient } from './Classes/RestClient';
import { WebConfig } from './Classes/WebConfig';

export *  from './Classes/RestClient';
export *  from './Classes/WebConfig';

@NgModule({
  declarations: [
    RestClient,
    WebConfig
  ],
  exports: [
    RestClient,
    WebConfig
  ]
})
export class GeneralModule
{

}
