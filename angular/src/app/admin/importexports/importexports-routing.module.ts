import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { ImportExportsComponent } from './importexports.component';

const routes:Routes=[
   {
    path:'',
    component:ImportExportsComponent,
    pathMatch: 'full'
   } 
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class ImportExportsRoutingModule {}