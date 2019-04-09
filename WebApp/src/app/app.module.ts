import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MatchFormComponent } from './match/match-form/match-form.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { MatchResultsComponent } from './match/match-results/match-results.component';
import { NavbarComponent } from './navbar/navbar.component';
import { HomeComponent } from './home/home.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MatchMygamesComponent } from './match/match-mygames/match-mygames.component';

@NgModule({
  declarations: [
    AppComponent,
    MatchFormComponent,
    MatchResultsComponent,
    NavbarComponent,
    HomeComponent,
    MatchMygamesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
