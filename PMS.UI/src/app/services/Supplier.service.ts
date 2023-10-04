import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Supplier } from 'src/app/models/supplier.model';

@Injectable({
  providedIn: 'root'
})
export class SupplierService {
  baseApiUrl: string = "https://localhost:7296";

constructor(private http: HttpClient) { }

getAllSupplier(): Observable<Supplier[]> {
  return this.http.get<Supplier[]>(this.baseApiUrl + '/api/Supplier');
}

addSupplier(newSupplier : Supplier) : Observable<Supplier>{
return this.http.post<Supplier>(this.baseApiUrl + 'api/Supplier', newSupplier);
}

}
