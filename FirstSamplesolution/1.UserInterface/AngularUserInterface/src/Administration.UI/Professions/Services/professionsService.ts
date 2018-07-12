import { Injectable, Type } from '@angular/core';
import { GetProfessionsSummaryResult} from '../Response/GetProfessionsSummaryResult';
import { GetProfessionsSummaryRequest} from '../Request/GetProfessionsSummaryRequest';
import { WebConfig, RestClient } from '../../../General/generalModule';

@Injectable()
export class ProfessionsService {
  private serviceUrl: string;

	constructor(private restClient: RestClient, private webConfig: WebConfig) {
    this.serviceUrl = this.webConfig.AdministrationServicesBaseUrl +
      this.webConfig.ProfessionsServiceRelativeUrl;
  }

	getProfessionsSummary(input: GetProfessionsSummaryRequest): GetProfessionsSummaryResult {
		return this.restClient.executePost<GetProfessionsSummaryResult>(this.serviceUrl +
      "GetProfessionsSummary", input);
	}
}
