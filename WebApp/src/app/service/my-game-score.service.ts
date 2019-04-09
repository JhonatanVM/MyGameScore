import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Match } from '../models/match';
import { Results } from '../models/Results';

@Injectable(
    { providedIn: 'root'}
)
export class MyGameScoreService {

    constructor(
        private http: HttpClient
    ) { }

    public insertMatch(obj: Match): Observable<Match> {
        return this.http.post<Match>(environment.ApiEndpoint + 'match', obj);
    }

    public getResults(): Observable<Results> {
        return this.http.get<Results>(environment.ApiEndpoint + 'match/results');
    }

    public get(): Observable<Match[]> {
        return this.http.get<Match[]>(environment.ApiEndpoint + 'match');
    }

    public deleteMatch(id: number) {
        return this.http.delete(environment.ApiEndpoint + `match?id=${ id }`);
    }
}
