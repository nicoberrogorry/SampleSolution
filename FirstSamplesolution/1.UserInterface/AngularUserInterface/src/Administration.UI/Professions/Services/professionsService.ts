import { Injectable, Inject } from '@angular/core';
import { GetProfessionsSummaryResult} from '../Response/GetProfessionsSummaryResult';
import { GetProfessionsSummaryRequest} from '../Request/GetProfessionsSummaryRequest';
import { WebConfig, RestClient } from '../../../General/generalModule';

@Injectable()
export class ProfessionsService {
  private _restClient: RestClient;
  private _webConfig: WebConfig;
  private _serviceUrl: string;

	constructor(@Inject(RestClient) restClient, @Inject(WebConfig) webConfig) {
    this._restClient = restClient;
    this._webConfig = webConfig;
    this._serviceUrl = this._webConfig.AdministrationServicesBaseUrl +
                        this._webConfig.ProfessionsServiceRelativeUrl;
  }

	getProfessionsSummary(input: GetProfessionsSummaryRequest): GetProfessionsSummaryResult {
		return this._restClient.executePost<GetProfessionsSummaryResult>(this._serviceUrl +
      "GetProfessionsSummary", input);
	}
}
