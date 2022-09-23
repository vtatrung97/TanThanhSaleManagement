import { Component, Injector, OnInit, ViewChild } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { ResultDtoOfVehicleListDto, VehicleDto, VehicleServiceProxy } from '@shared/service-proxies/vehicleService';
import { finalize } from 'rxjs/operators';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { DateTime } from 'luxon';
import { LazyLoadEvent } from 'primeng/api';
import { Paginator } from 'primeng/paginator';
import { Table } from 'primeng/table';
import { DateTimeService } from '@app/shared/common/timing/date-time.service';
import { CreateVehicleModalComponent } from './create-vehicle-modal.component';
import { EditVehicleModalComponent } from './edit-vehicle-modal.component';

@Component({
  selector: 'app-vehicles',
  templateUrl: './vehicles.component.html',
  styleUrls: ['./vehicles.component.less'],
  animations: [appModuleAnimation()],
})
export class VehiclesComponent extends AppComponentBase implements OnInit {
  @ViewChild('createVehicleModal', { static: true }) createVehicleModal: CreateVehicleModalComponent;
  @ViewChild('editVehicleModal', { static: true }) editVehicleModal: EditVehicleModalComponent;

  vehicles: VehicleDto[];
  filters: any = {
    filterText: '',
  };
  constructor(injector: Injector, private vehicleService: VehicleServiceProxy) {
    super(injector);
  }

  ngOnInit(): void {
    this.getVehicles();
  }

  getVehicles($event?: LazyLoadEvent): void {
    const self = this;
    self.vehicleService
      .getAll('')
      .pipe(finalize(() => this.primengTableHelper.hideLoadingIndicator()))
      .subscribe((result) => {
        self.vehicles = result.items;
        self.primengTableHelper.records = result.items;
        self.primengTableHelper.totalRecordsCount = result.items.length;
      });
  }

  createVehicle(): void {
    this.createVehicleModal.show();
  }

  deleteVehicle(vehicle: VehicleDto): void {
    this.message.confirm(this.l('DeleteVehicleWarningMessage'), this.l('AreYouSure'), (isConfirmed) => {
      if (isConfirmed) {
        this.vehicleService.delete(vehicle.id).subscribe(() => {
          this.getVehicles();
          this.notify.success(this.l('SuccessfullyDeleted'));
        });
      }
    });
  }

  updateVehicle(vehicle: VehicleDto): void {
    this.editVehicleModal.show();
    this.editVehicleModal.loadVehicle(vehicle.id);
  }

  insertRow(e): void {
    this.primengTableHelper.isLoading = true;
    this.vehicleService
      .create(e.data)
      .pipe(finalize(() => (this.primengTableHelper.isLoading = false)))
      .subscribe(() => {
        this.notify.info(this.l('SavedSuccessfully'));
        this.getVehicles();
      });
  }
  validateRemove(e): void {
    var isCanceled = e.cancel;
    if (!isCanceled) {
      this.vehicleService.delete(e.key).subscribe(() => {
        this.getVehicles();
        this.notify.success(this.l('SuccessfullyDeleted'));
      });
    }
  }
}
