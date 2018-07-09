//#region angular2 imports
import {
	Injectable,
	Inject,
	EventEmitter,
	forwardRef
} from "@angular/core";
import {Http, Request, Response, RequestMethod, RequestOptions, URLSearchParams} from "@angular/http";
//#endregion

@Injectable()
export class Proxy {
	public _http: Http;

	protected _baseUrl: string;

	protected _onUnauthorizedRequest: EventEmitter<any>;

	networkProblemsDetected: boolean;

	protected _reqId: string = "reqId";

	constructor(http: Http) {
		this._http = http;
		this._baseUrl ="";// AppConfig.AppSettings.webApiBaseUrl;
		this._onUnauthorizedRequest = new EventEmitter<any>();
		}

	protected createRequest(relativeUrl: string, method: RequestMethod, body: string): Request {

		let url: string = "";

		let result: Request;
		result = new Request(new RequestOptions({
			url: url,
			method: method,
			body: body
		}));

		return result;
	}

    public setRequestMethod(method: RequestMethod) {
	//	(<CustomBrowserXhr>(<any>this._http)._backend._browserXHR).requestMethod = method;
    }
    
    protected retryRequest(request: Request, relativeUrl: string, count?: number) {
		var self = this;
		// let observable = this._http.request(request).map(this.mapResponse.bind(this, request.url, relativeUrl));
		// observable.subscribe(
		// 	function (data: any) {
			
		// 	},
		// 	function (error: Response) {
				
		// 	},
		// 	this.onComplete.bind(this));
	}

    onComplete(data: any) {
		//this.unsubscribe();
    }
    
	executeGet(relativeUrl: string, offlineMode?: boolean, blobRequest?: boolean): any {
		this.setRequestMethod(RequestMethod.Get);
    	
		var request: Request;
		request = this.createRequest(relativeUrl, RequestMethod.Get, null);
		this.retryRequest( request, relativeUrl);
        
        return "subject";

	}

	executePost(relativeUrl: string, data: any): any {
		this.setRequestMethod(RequestMethod.Post);
		let self = this;

		let dataInput: any;
        var request = this.createRequest(relativeUrl, RequestMethod.Post,  data);
		request.headers.append('Content-Type', 'application/json');

	//	let observable = this._http.request(request).map(this.mapResponse.bind(this, request.url, relativeUrl));
		
		return "subject";
	}

	mapResponse(url: string, relativeUrl: string, response: Response) {
		let result: any = null;
		if (response.status > 199 && response.status < 299) {//response.ok is not available yet
			if (response.headers.get("Content-Type").indexOf("application/json") > -1) {
				result = response.json();
				
				//result = serializationUtils.deserializeObjects(result);
			}
			
			return result;
		}
	}

}
