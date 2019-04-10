import { Component, OnInit } from '@angular/core';
import { MyGameScoreService } from 'src/app/service/my-game-score.service';
import { Match } from 'src/app/models/match';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-match-mygames',
  templateUrl: './match-mygames.component.html',
  styleUrls: ['./match-mygames.component.scss']
})
export class MatchMygamesComponent implements OnInit {

  private matches: Match[];
  private vazio = false;
  private carregando = true;

  constructor(
    private myGameScoreService: MyGameScoreService
  ) { }

  ngOnInit() {
    this.get();
  }

  public get() {
    this.myGameScoreService.get()
      .subscribe(
        (response) => {
          this.carregando = false;
          if (response.length === 0) {
            this.vazio = true;
          } else {
            this.matches = response;
          }
        },
        (error: HttpErrorResponse) => {
          console.log(error.message);
          this.carregando = false;
        });
  }

  public deleteMatch(match: Match) {
    this.myGameScoreService.deleteMatch(match.id)
      .subscribe(
        () => {
          this.atualizaLista(match);
          if (this.matches.length === 0) {
            this.vazio = true;
          }
        },
        (error: HttpErrorResponse) => {
          alert('Não foi possível deletar.');
          console.log(error.message);
        });
  }

  public atualizaLista(match: Match) {
    const index = this.matches.findIndex(e => e.id === match.id);
    this.matches.splice(index, 1);
  }
}
