import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsComponent } from './components/products/products.component';
import { AddProductComponent } from './components/add-product/add-product.component';
import { EditProductComponent } from './components/edit-product/edit-product.component';
import { SuppliersComponent } from './components/Suppliers/suppliers/suppliers.component';
import { AddSupplierComponent } from './components/Suppliers/suppliers/AddSupplier/AddSupplier/AddSupplier.component';
import { EditSupplierComponent } from './components/Suppliers/suppliers/EditSupplier/EditSupplier/EditSupplier.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    AddProductComponent,
    EditProductComponent,
    SuppliersComponent,
    AddSupplierComponent,
    EditSupplierComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
