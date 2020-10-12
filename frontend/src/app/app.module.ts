import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

//#region Modules
import { AppRoutingModule } from './app-routing.module';
import { HomeModule } from './modules/home/home.module';
import { CoreModule } from './core/core.module';
import { HttpClientModule } from '@angular/common/http';
//#endregion

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    HomeModule,
    CoreModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
