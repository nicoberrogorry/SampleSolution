import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";

@Injectable()
export class RestClient {
  private _httpClient: HttpClient;

  private _httpOptions = {
    // Setting text/plain content type to avoid preflighted CORS Request
    headers: new HttpHeaders({'Content-Type':  'text/plain'}),
    responseType: 'text' as 'text'
  }

	constructor(httpClient: HttpClient) {
    this._httpClient = httpClient;
  }

	/*executePost<ResponseType>(url: string, body: any): Observable<ResponseType> {
    let result: Observable<ResponseType> =
      this._httpClient.post<ResponseType>(url, JSON.stringify(body), this._httpOptions);
    return result;
	}*/
  executePost(url: string, body: any): Observable<string> {
    let result: Observable<string> = this._httpClient.post(url, JSON.stringify(body), this._httpOptions);
    result.subscribe(res => console.log("RestClient recieved: " + res));
    return result;
  }

}
