import { Component, EventEmitter, Injector, OnInit, Output, ViewChild } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { VehicleDto, VehicleServiceProxy } from '@shared/service-proxies/vehicleService';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs/operators';

@Component({
    selector: 'editVehicleModal',
    templateUrl: './edit-vehicle-modal.component.html',
    styleUrls: ['./edit-vehicle-modal.component.less']
})
export class EditVehicleModalComponent extends AppComponentBase implements OnInit {
    active:boolean=false;
    saving:boolean=false;
    @ViewChild('editModal', { static: true }) modal: ModalDirective;

    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();
    vehicle:VehicleDto=new VehicleDto();
    constructor(injector:Injector,private vehicleService: VehicleServiceProxy) {
        super(injector);
     }

    ngOnInit(): void { }
    save():void{
        console.log(this.vehicle);
        this.vehicleService.update(this.vehicle)
            .pipe(finalize(() => this.saving = false))
            .subscribe(() => {
                this.notify.info(this.l('SavedSuccessfully'));
                this.close();
                this.modalSave.emit(null);
            });
    }

    close():void{
        this.active = false;
        this.modal.hide();
    }
    show() {
        this.active = true;
        this.init();
            this.modal.show();
    }
    onShown(): void {
        document.getElementById('Manufacturer').focus();
    }

    init(): void {
        const self=this;
    }

    loadVehicle(id:number):void{
        const self=this;
        self.vehicleService.get(id).pipe(finalize(() => this.primengTableHelper.hideLoadingIndicator())).subscribe(result => {
            self.vehicle=result;
        })
    }
}
