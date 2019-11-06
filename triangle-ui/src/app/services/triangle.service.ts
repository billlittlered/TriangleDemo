import { map, filter, switchMap, catchError } from 'rxjs/operators';
import { Coordinate } from '../models/coordinate';
import { Injectable } from '@angular/core';
import { HttpClient , HttpHeaders } from '@angular/common/http';
import { Constants } from '../constants';
import { Observable, throwError } from 'rxjs';

@Injectable()
export class TriangleService {
  constructor(private http: HttpClient) {
  }

  public getCoordinates(row: string, column: number): Observable<string> {
      return this.http.get<string>(`${Constants.ApiBaseUrl}/GetCoordinates/${row}/${column}`, { responseType: 'text' })
        .pipe(
          map(res => res),
          catchError(error => throwError(error.message || error))
        );
  }

}
