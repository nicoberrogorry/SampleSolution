import { Injectable, Inject } from '@angular/core';
import { GetProfessionsSummaryRequest } from '../Request/GetProfessionsSummaryRequest';
import { GetProfessionsSummaryResponse } from '../Response/GetProfessionsSummaryResponse';

import { WebConfig, RestClient } from '../../../General/generalModule';
import { Observable } from 'rxjs';
import { ProfessionSummary } from '../Classes/ProfessionSummary';
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

	getProfessionsSummary(input: GetProfessionsSummaryRequest): Promise<GetProfessionsSummaryResponse> {
    let result: Promise<GetProfessionsSummaryResponse>;

    let url = this._serviceUrl + "GetProfessionsSummary";
    result = this._restClient.executePost(url, input).pipe(
      map(serverResponse =>{
        console.log("ProfessionsService Recieved: " + serverResponse);
        
        let jsonResponse = JSON.parse(serverResponse);
        let mappedResponse: GetProfessionsSummaryResponse = <GetProfessionsSummaryResponse>{
          ProfessionsSummary: []
        }
        jsonResponse["GetProfessionsSummaryResult"]["ProfessionsSummary"].forEach( jsonProfessionSummary => {
          let professionSummary: ProfessionSummary = <ProfessionSummary>{
            ProfessionId: jsonProfessionSummary["ProfessionId"],
            Description: jsonProfessionSummary["Description"]
          }
          mappedResponse.ProfessionsSummary.push(professionSummary);
        })
        return mappedResponse;
      })
    ).toPromise();
    return result;
	}
}
