import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";

@Injectable()
export class RestClient {
  private httpOptions = {
    headers: new HttpHeaders({'Content-Type':  'application/json'})
  }

	constructor(private httpClient: HttpClient) {}

	executePost<RESPONSE>(url: string, body: any): RESPONSE {
    let result: RESPONSE;
    this.httpClient.post<RESPONSE>(url, JSON.stringify(body), this.httpOptions)
      .subscribe(response => {result = response});
    return result;
	}
}
