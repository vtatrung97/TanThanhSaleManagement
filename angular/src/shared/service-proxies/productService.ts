import { mergeMap as _observableMergeMap, catchError as _observableCatch } from 'rxjs/operators';
import { Observable, throwError as _observableThrow, of as _observableOf } from 'rxjs';
import { Injectable, Inject, Optional, InjectionToken } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse, HttpResponseBase } from '@angular/common/http';

import { DateTime, Duration } from 'luxon';
import { ApiException, API_BASE_URL } from './service-proxies';

// export const API_BASE_URL = new InjectionToken<string>('API_BASE_URL');

@Injectable()
export class ProductServiceProxy {
  private http: HttpClient;
  private baseUrl: string;
  protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

  constructor(@Inject(HttpClient) http: HttpClient, @Optional() @Inject(API_BASE_URL) baseUrl?: string) {
    this.http = http;
    this.baseUrl = baseUrl !== undefined && baseUrl !== null ? baseUrl : '';
  }


  getAll(keyWord: string | undefined): Observable<ResultDtoOfProductListDto> {
    let url_ = this.baseUrl + '/api/services/app/Product/GetAll?';
    let options_: any = {
      observe: 'response',
      responseType: 'blob',
      headers: new HttpHeaders({
        Accept: 'text/plain',
      }),
    };

    return this.http
      .request('get', url_, options_)
      .pipe(
        _observableMergeMap((response_: any) => {
          return this.processGetAll(response_);
        })
      )
      .pipe(
        _observableCatch((response_: any) => {
          if (response_ instanceof HttpResponseBase) {
            try {
              return this.processGetAll(<any>response_);
            } catch (e) {
              return <Observable<ResultDtoOfProductListDto>>(<any>_observableThrow(e));
            }
          } else return <Observable<ResultDtoOfProductListDto>>(<any>_observableThrow(response_));
        })
      );
  }
  protected processGetAll(response: HttpResponseBase): Observable<ResultDtoOfProductListDto> {
    const status = response.status;
    const responseBlob =
      response instanceof HttpResponse
        ? response.body
        : (<any>response).error instanceof Blob
        ? (<any>response).error
        : undefined;

    let _headers: any = {};
    if (response.headers) {
      for (let key of response.headers.keys()) {
        _headers[key] = response.headers.get(key);
      }
    }
    if (status === 200) {
      return blobToText(responseBlob).pipe(
        _observableMergeMap((_responseText) => {
          let result200: any = null;
          let resultData200 = _responseText === '' ? null : JSON.parse(_responseText, this.jsonParseReviver);
          result200 = ResultDtoOfProductListDto.fromJS(resultData200);
          return _observableOf(result200);
        })
      );
    } else if (status !== 200 && status !== 204) {
      return blobToText(responseBlob).pipe(
        _observableMergeMap((_responseText) => {
          return throwException('An unexpected server error occurred.', status, _responseText, _headers);
        })
      );
    }
    return _observableOf<ResultDtoOfProductListDto>(<any>null);
  }

  get(id: number): Observable<ProductDto> {
    let url_ = this.baseUrl + '/api/services/app/Product/Get?id='+id;
    let options_: any = {
      observe: 'response',
      responseType: 'blob',
      headers: new HttpHeaders({
        Accept: 'text/plain',
      }),
    };

    return this.http
      .request('get', url_, options_)
      .pipe(
        _observableMergeMap((response_: any) => {
          return this.processGet(response_);
        })
      )
      .pipe(
        _observableCatch((response_: any) => {
          if (response_ instanceof HttpResponseBase) {
            try {
              return this.processGet(<any>response_);
            } catch (e) {
              return <Observable<ProductDto>>(<any>_observableThrow(e));
            }
          } else return <Observable<ProductDto>>(<any>_observableThrow(response_));
        })
      );
  }
  protected processGet(response: HttpResponseBase): Observable<ProductDto> {
    const status = response.status;
    const responseBlob =
      response instanceof HttpResponse
        ? response.body
        : (<any>response).error instanceof Blob
        ? (<any>response).error
        : undefined;

    let _headers: any = {};
    if (response.headers) {
      for (let key of response.headers.keys()) {
        _headers[key] = response.headers.get(key);
      }
    }
    if (status === 200) {
      return blobToText(responseBlob).pipe(
        _observableMergeMap((_responseText) => {
          let result200: any = null;
          let resultData200 = _responseText === '' ? null : JSON.parse(_responseText, this.jsonParseReviver);
          result200 = ProductDto.fromJS(resultData200);
          return _observableOf(result200);
        })
      );
    } else if (status !== 200 && status !== 204) {
      return blobToText(responseBlob).pipe(
        _observableMergeMap((_responseText) => {
          return throwException('An unexpected server error occurred.', status, _responseText, _headers);
        })
      );
    }
    return _observableOf<ProductDto>(<any>null);
  }

  create(body: ProductDto | undefined): Observable<void> {
    let url_ = this.baseUrl + '/api/services/app/Product/Create';
    url_ = url_.replace(/[?&]$/, '');

    const content_ = JSON.stringify(body);

    let options_: any = {
      body: content_,
      observe: 'response',
      responseType: 'blob',
      headers: new HttpHeaders({
        'Content-Type': 'application/json-patch+json',
      }),
    };

    return this.http
      .request('post', url_, options_)
      .pipe(
        _observableMergeMap((response_: any) => {
          return this.processCreate(response_);
        })
      )
      .pipe(
        _observableCatch((response_: any) => {
          if (response_ instanceof HttpResponseBase) {
            try {
              return this.processCreate(<any>response_);
            } catch (e) {
              return <Observable<void>>(<any>_observableThrow(e));
            }
          } else return <Observable<void>>(<any>_observableThrow(response_));
        })
      );
  }

  protected processCreate(response: HttpResponseBase): Observable<void> {
    const status = response.status;
    const responseBlob =
      response instanceof HttpResponse
        ? response.body
        : (<any>response).error instanceof Blob
        ? (<any>response).error
        : undefined;

    let _headers: any = {};
    if (response.headers) {
      for (let key of response.headers.keys()) {
        _headers[key] = response.headers.get(key);
      }
    }
    if (status === 200) {
      return blobToText(responseBlob).pipe(
        _observableMergeMap((_responseText) => {
          return _observableOf<void>(<any>null);
        })
      );
    } else if (status !== 200 && status !== 204) {
      return blobToText(responseBlob).pipe(
        _observableMergeMap((_responseText) => {
          return throwException('An unexpected server error occurred.', status, _responseText, _headers);
        })
      );
    }
    return _observableOf<void>(<any>null);
  }

  update(body: ProductDto | undefined): Observable<void> {
    let url_ = this.baseUrl + '/api/services/app/Product/Update?id='+body.id;
    url_ = url_.replace(/[?&]$/, '');

    const content_ = JSON.stringify(body);

    let options_: any = {
      body: content_,
      observe: 'response',
      responseType: 'blob',
      headers: new HttpHeaders({
        'Content-Type': 'application/json-patch+json',
      }),
    };

    return this.http
      .request('put', url_, options_)
      .pipe(
        _observableMergeMap((response_: any) => {
          return this.processUpdate(response_);
        })
      )
      .pipe(
        _observableCatch((response_: any) => {
          if (response_ instanceof HttpResponseBase) {
            try {
              return this.processUpdate(<any>response_);
            } catch (e) {
              return <Observable<void>>(<any>_observableThrow(e));
            }
          } else return <Observable<void>>(<any>_observableThrow(response_));
        })
      );
  }

  protected processUpdate(response: HttpResponseBase): Observable<void> {
    const status = response.status;
    const responseBlob =
      response instanceof HttpResponse
        ? response.body
        : (<any>response).error instanceof Blob
        ? (<any>response).error
        : undefined;

    let _headers: any = {};
    if (response.headers) {
      for (let key of response.headers.keys()) {
        _headers[key] = response.headers.get(key);
      }
    }
    if (status === 200) {
      return blobToText(responseBlob).pipe(
        _observableMergeMap((_responseText) => {
          return _observableOf<void>(<any>null);
        })
      );
    } else if (status !== 200 && status !== 204) {
      return blobToText(responseBlob).pipe(
        _observableMergeMap((_responseText) => {
          return throwException('An unexpected server error occurred.', status, _responseText, _headers);
        })
      );
    }
    return _observableOf<void>(<any>null);
  }

  delete(id: number | undefined): Observable<void> {
    let url_ = this.baseUrl + '/api/services/app/Product/Delete?id='+id;
    url_ = url_.replace(/[?&]$/, '');

    let options_: any = {
      observe: 'response',
      responseType: 'blob',
      headers: new HttpHeaders({
        Accept: 'text/plain',
      }),
    };

    return this.http
      .request('delete', url_, options_)
      .pipe(
        _observableMergeMap((response_: any) => {
          return this.processCreate(response_);
        })
      )
      .pipe(
        _observableCatch((response_: any) => {
          if (response_ instanceof HttpResponseBase) {
            try {
              return this.processCreate(<any>response_);
            } catch (e) {
              return <Observable<void>>(<any>_observableThrow(e));
            }
          } else return <Observable<void>>(<any>_observableThrow(response_));
        })
      );
  }

  protected processDelete(response: HttpResponseBase): Observable<void> {
    const status = response.status;
    const responseBlob =
      response instanceof HttpResponse
        ? response.body
        : (<any>response).error instanceof Blob
        ? (<any>response).error
        : undefined;

    let _headers: any = {};
    if (response.headers) {
      for (let key of response.headers.keys()) {
        _headers[key] = response.headers.get(key);
      }
    }
    if (status === 200) {
      return blobToText(responseBlob).pipe(
        _observableMergeMap((_responseText) => {
          return _observableOf<void>(<any>null);
        })
      );
    } else if (status !== 200 && status !== 204) {
      return blobToText(responseBlob).pipe(
        _observableMergeMap((_responseText) => {
          return throwException('An unexpected server error occurred.', status, _responseText, _headers);
        })
      );
    }
    return _observableOf<void>(<any>null);
  }
}

export class ResultDtoOfProductListDto implements IResultDtoOfProductListDto {
  items!: ProductDto[] | undefined;

  constructor(data?: ResultDtoOfProductListDto) {
    if (data) {
      for (var property in data) {
        if (data.hasOwnProperty(property)) (<any>this)[property] = (<any>data)[property];
      }
    }
  }

  init(_data?: any) {
    if (_data) {
      if (Array.isArray(_data['items'])) {
        this.items = [] as any;
        for (let item of _data['items']) this.items!.push(ProductDto.fromJS(item));
      }
    }
  }

  static fromJS(data: any): ResultDtoOfProductListDto {
    data = typeof data === 'object' ? data : {};
    let result = new ResultDtoOfProductListDto();
    result.init(data);
    return result;
  }

  toJSON(data?: any) {
    data = typeof data === 'object' ? data : {};
    if (Array.isArray(this.items)) {
      data['items'] = [];
      for (let item of this.items) data['items'].push(item.toJSON());
    }
    return data;
  }
}

export class ProductDto implements IProductDto {
  name: string;
  description: string;
  creationTime: DateTime;
  weight: number;
  isGasTankSell: boolean;
  id: number;

  constructor(data?: IProductDto) {
    if (data) {
      for (var property in data) {
        if (data.hasOwnProperty(property)) (<any>this)[property] = (<any>data)[property];
      }
    }
  }

  init(_data?: any) {
    if (_data) {
      this.name = _data['name'];
      this.description = _data['description'];
      this.creationTime = _data['creationTime'] ? DateTime.fromISO(_data['creationTime'].toString()) : <any>undefined;
      this.weight = _data['weight'];
      this.isGasTankSell = _data['isGasTankSell'];
      this.id = _data['id'];
    }
  }

  static fromJS(data: any): ProductDto {
    data = typeof data === 'object' ? data : {};
    let result = new ProductDto();
    result.init(data);
    return result;
  }

  toJSON(data?: any) {
    data = typeof data === 'object' ? data : {};
    data['name'] = this.name;
    data['description'] = this.description;
    data['creationTime'] = this.creationTime ? this.creationTime.toString() : <any>undefined;
    data['weight'] = this.weight;
    data['isGasTankSell'] = this.isGasTankSell;
    data['id'] = this.id;
    return data;
  }
}

export interface IProductDto {
  name: string;
  description: string;
  creationTime: DateTime | undefined;
  weight: number;
  isGasTankSell: boolean;
  id: number;
}

export interface IResultDtoOfProductListDto {
  items: ProductDto[] | undefined;
}

function throwException(
  message: string,
  status: number,
  response: string,
  headers: { [key: string]: any },
  result?: any
): Observable<any> {
  if (result !== null && result !== undefined) return _observableThrow(result);
  else return _observableThrow(new ApiException(message, status, response, headers, null));
}

function blobToText(blob: any): Observable<string> {
  return new Observable<string>((observer: any) => {
    if (!blob) {
      observer.next('');
      observer.complete();
    } else {
      let reader = new FileReader();
      reader.onload = (event) => {
        observer.next((<any>event.target).result);
        observer.complete();
      };
      reader.readAsText(blob);
    }
  });
}
