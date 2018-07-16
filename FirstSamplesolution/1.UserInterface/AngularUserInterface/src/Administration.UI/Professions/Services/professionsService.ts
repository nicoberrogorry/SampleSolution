import { Injectable, Inject } from '@angular/core';
import { GetProfessionsSummaryRequest } from '../Request/GetProfessionsSummaryRequest';
import { GetProfessionsSummaryResponse } from '../Response/GetProfessionsSummaryResponse';

import { WebConfig, RestClient } from '../../../General/generalModule';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable()
export class ProfessionsService {
  private _restClient: RestClient;
  private _webConfig: WebConfig;
  private _serviceUrl: string;

	constructor(restClient: RestClient, webConfig: WebConfig) {
    this._restClient = restClient;
    this._webConfig = webConfig;
    this._serviceUrl =
      this._webConfig.AdministrationServicesBaseUrl + this._webConfig.ProfessionsServiceRelativeUrl;
  }

	getProfessionsSummary(input: GetProfessionsSummaryRequest): Observable<GetProfessionsSummaryResponse> {
    let result: Observable<GetProfessionsSummaryResponse>;
    let url = this._serviceUrl + "GetProfessionsSummary";
    result = this._restClient.executePost<GetProfessionsSummaryResponse>(url, input);
    result.subscribe( response => console.log("ProfessionsSummary recieved: ", response) );
    return result;
	}
}
