import { Injectable, Type } from '@angular/core';
import { Proxy } from '../../../General/Services/Proxy';
import { GetProfessionsIn } from '../MethodParameters/getProfessionsIn';
import { GetProfessionsOut } from '../MethodParameters/getProfessionsOut';

@Injectable()
export class ProfessionsProxy {
	protected _proxy: Proxy;
	public get proxy(): Proxy {
		return this._proxy;
	}

	constructor(proxy: Proxy) {
		this._proxy = proxy;
	}

	getProfessions(input: GetProfessionsIn): any {
		let response = this.proxy.executePost('Administration/LoadProfessionSummaryViewModelList', input).map(this.mapGetProfessionsDataResponse.bind(this));
		return response;
	}

	mapGetProfessionsDataResponse(response: any): GetProfessionsOut {
        let result : GetProfessionsOut;
        
        // mapping result
		return result;
	}

}
