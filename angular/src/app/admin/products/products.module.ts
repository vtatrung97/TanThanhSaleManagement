import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductsRoutingModule } from './products-routing.module';
import { ProductsComponent } from './products.component';
import { AppSharedModule } from '@app/shared/app-shared.module';
import { AdminSharedModule } from '../shared/admin-shared.module';

@NgModule({
    declarations: [ProductsComponent],
    imports: [AppSharedModule, AdminSharedModule, ProductsRoutingModule ],
    exports: [],
    providers: [],
})
export class ProductsModule {}