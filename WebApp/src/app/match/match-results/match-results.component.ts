import { Component, OnInit } from '@angular/core';
import { MyGameScoreService } from 'src/app/service/my-game-score.service';
import { HttpErrorResponse } from '@angular/common/http';
import { Results } from 'src/app/models/Results';

@Component({
  selector: 'app-match-results',
  templateUrl: './match-results.component.html',
  styleUrls: ['./match-results.component.scss']
})
export class MatchResultsComponent implements OnInit {

  private results: Results;
  private vazio = false;
  private carregando = true;

  constructor(
    private myGameScoreService: MyGameScoreService
  ) { }

  ngOnInit() {
    this.getResults();
  }

  public getResults() {
    this.myGameScoreService.getResults()
    .subscribe((response) => {
      this.carregando = false;
      if (response == null) {
        this.vazio = true;
      }
      this.results = response;
    },
    (error: HttpErrorResponse) => {
      this.carregando = false;
      console.log(error.message);
    });
  }
}
