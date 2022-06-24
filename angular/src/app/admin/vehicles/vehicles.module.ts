import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { VehiclesRoutingModule } from './vehicles-routing.module';
import { VehiclesComponent } from './vehicles.component';
import { AppSharedModule } from '@app/shared/app-shared.module';
import { AdminSharedModule } from '../shared/admin-shared.module';
import { CreateVehicleModalComponent } from './create-vehicle-modal.component';
import { EditVehicleModalComponent } from './edit-vehicle-modal.component';

@NgModule({
    declarations: [VehiclesComponent,CreateVehicleModalComponent,EditVehicleModalComponent],
    imports: [AppSharedModule, AdminSharedModule, VehiclesRoutingModule ],
    exports: [],
    providers: [],
})
export class VehiclesModule {}