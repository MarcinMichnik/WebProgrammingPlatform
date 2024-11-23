import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public processingResponse: ProcessingResponse | undefined;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<ProcessingResponse>(baseUrl + 'processing').subscribe(result => {
      this.processingResponse = result;
    }, error => console.error(error));
  }
}

interface ProcessingResponse {
  responseContent: string;
}
