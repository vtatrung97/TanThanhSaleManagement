import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router, RouterModule, Routes } from '@angular/router';
import { ProductsComponent } from './products.component';

const routes:Routes=[
    {
        path: '',
        component: ProductsComponent,
        pathMatch: 'full'
}]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class ProductsRoutingModule {}