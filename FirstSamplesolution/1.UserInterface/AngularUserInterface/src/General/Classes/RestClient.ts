import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";

@Injectable()
export class RestClient {
  private _httpClient: HttpClient;

  private _httpOptions = {
    // Setting text/plain content type to avoid preflighted CORS Request
    headers: new HttpHeaders({'Content-Type':  'text/plain'})
  }

	constructor(httpClient: HttpClient) {
    this._httpClient = httpClient;
  }

  executePost<Response>(url: string, body: any): Observable<Response> {
    let result: Observable<Response> = this._httpClient.post<Response>(url, JSON.stringify(body), this._httpOptions);
    result.subscribe(response => console.log("RestClient recieved: ", response));
    return result;
  }

}
