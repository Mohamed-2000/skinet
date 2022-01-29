import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IProduct } from 'src/app/shared/models/product';
import { ShopService } from '../shop.service';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.scss']
})
export class ProductDetailsComponent implements OnInit {
  product!: IProduct;
  //productId!: string;
  constructor(private shopService:ShopService, private activateRoute:ActivatedRoute) { }

  ngOnInit(): void {
    this.loadProduct();
  }

  loadProduct () {
      // this.shopService.getProduct(+this.activateRoute.snapshot.paramMap.get('id')).subscribe ==> udemy code
      //console.log(+this.activateRoute.snapshot.params['id']);
      //this.productId = this.activateRoute.snapshot.params.id;
      //var convertIdToString = Number(this.activateRoute.snapshot.paramMap.get('id'))
      //console.log(Number(this.productId));

      // this.activateRoute.paramMap.subscribe(params => {
      //   if (this.productId) {
      //   this.productId = params.get('id');

      //   }
      // });


      this.activateRoute.params.subscribe(a=> {
        this.shopService.getProduct(a['id']).subscribe( product =>
          this.product = product
        )
      }, error => {
        console.log(error);

      });
      // this.shopService.getProduct(+this.productId).subscribe(product =>
      // {
      //   if(product){
      //     this.product = product;

      //   }
      // }, error => {
      //   console.log(error);

      // });
  }

}
