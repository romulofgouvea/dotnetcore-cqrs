import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CoreRoutingModule } from './core-routing.module';

import { AppConfig, APP_CONFIG } from './config/app.config';

@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
    CoreRoutingModule,
  ],
  exports: [
  ],
  providers: [
    { provide: APP_CONFIG, useValue: AppConfig },
  ]
})
export class CoreModule { }
