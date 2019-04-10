import { Component, OnInit } from '@angular/core';
import { MyGameScoreService } from '../../service/my-game-score.service';
import { HttpErrorResponse } from '@angular/common/http';
import { Results } from '../../models/Results';
import { Match } from '../../models/match';

@Component({
  selector: 'app-match-form',
  templateUrl: './match-form.component.html',
  styleUrls: ['./match-form.component.scss']
})
export class MatchFormComponent implements OnInit {

  private match: Match = new Match();

  constructor(
    private myGameScoreService: MyGameScoreService
  ) { }

  ngOnInit() {
  }

  public insertMatch() {
    this.myGameScoreService.insertMatch(this.match)
      .subscribe(
        (response) => {
          alert('Inserido com sucesso!');
          this.match = new Match();
        },
        (error: HttpErrorResponse) => {
          if (error.status === 400) {
            alert('Dado\(s\) inválido\(s\).');
            console.log(error.message);
          } else {
            alert('Erro interno do servidor.');
          }
        });
  }
}
