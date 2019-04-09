import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MatchFormComponent } from './match/match-form/match-form.component';
import { MatchResultsComponent } from './match/match-results/match-results.component';
import { HomeComponent } from './home/home.component';
import { MatchMygamesComponent } from './match/match-mygames/match-mygames.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'match', component: MatchFormComponent },
  { path: 'mygames', component: MatchMygamesComponent },
  { path: 'results', component: MatchResultsComponent },
  { path: '**', component: HomeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
