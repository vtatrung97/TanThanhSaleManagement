import { Component, Injector, OnInit } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/common/app-component-base';
import { ProductDto, ProductServiceProxy } from '@shared/service-proxies/productService';
import { LazyLoadEvent } from 'primeng/api';
import { finalize } from 'rxjs/operators';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.less'],
  animations: [appModuleAnimation()],
})
export class ProductsComponent extends AppComponentBase implements OnInit {
  constructor(injector: Injector, private productService: ProductServiceProxy) {
    super(injector);
  }
  products: ProductDto[];

  ngOnInit(): void {
    this.getProducts();
  }
  getProducts($event?: LazyLoadEvent): void {
    const self = this;
    self.productService
      .getAll('')
      .pipe(finalize(() => this.primengTableHelper.hideLoadingIndicator()))
      .subscribe((result) => {
        self.products = result.items;
        self.primengTableHelper.records = result.items;
        self.primengTableHelper.totalRecordsCount = result.items.length;
      });
  }
  insertRow(e):void{
    this.primengTableHelper.isLoading = true;
    this.productService
      .create(e.data)
      .pipe(finalize(() => (this.primengTableHelper.isLoading = false)))
      .subscribe(() => {
        this.notify.info(this.l('SavedSuccessfully'));
        this.getProducts();
      });
  }

  validateRemove(e):void{

  }
}
