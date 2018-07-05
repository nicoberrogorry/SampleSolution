import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { environment } from './environments/environment';
import { AngularUserInterfaceModule } from './AngularUserInterface.UI/angularUserInterfaceModule';


if (environment.production) {
  enableProdMode();
}

platformBrowserDynamic().bootstrapModule(AngularUserInterfaceModule)
  .catch(err => console.log(err));
