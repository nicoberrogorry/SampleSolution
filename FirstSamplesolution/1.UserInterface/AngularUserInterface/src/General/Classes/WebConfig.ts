import { Injectable } from "@angular/core";

@Injectable()
export class WebConfig
{
  public AdministrationServicesBaseUrl: string = "http://192.168.1.43/SampleSolutionServices/Administration/";
  public PersonsServiceRelativeUrl: string =  "PersonsService.svc/REST/";
  public ProfessionsServiceRelativeUrl: string = "ProfessionsService.svc/REST/";
}
