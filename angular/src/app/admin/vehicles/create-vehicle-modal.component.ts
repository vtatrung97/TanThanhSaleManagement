import { Component, OnInit,ViewChild,Output,EventEmitter,Injector } from '@angular/core';
import { filter as _filter } from 'lodash-es';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs/operators';
import { VehicleDto, VehicleServiceProxy} from '@shared/service-proxies/vehicleService';
import { AppComponentBase } from '@shared/common/app-component-base';

@Component({
    selector: 'createVehicleModal',
    templateUrl: './create-vehicle-modal.component.html',
    styleUrls: ['./create-vehicle-modal.component.less']
})
export class CreateVehicleModalComponent extends AppComponentBase implements OnInit {
    @ViewChild('createModal', { static: true }) modal: ModalDirective;

    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();
    active = false;
    saving = false;
    vehicle:VehicleDto=new VehicleDto();
    constructor( injector: Injector,private vehicleService:VehicleServiceProxy) { 
        super(injector);
    }

    ngOnInit(): void { }

    save():void{
        this.vehicleService.create(this.vehicle)
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
        this.vehicle=new VehicleDto();
    }
}
