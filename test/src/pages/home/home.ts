import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { CallApiProvider } from '../../providers/call-api/call-api';
import { FormGroup, FormBuilder } from '@angular/forms';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  products: any;
  newCart : FormGroup

  constructor(public fb: FormBuilder ,public navCtrl: NavController, public CallApi: CallApiProvider) {
    this.newCart = fb.group ({
      'id' : null,
      'productName' : null,
      'price' : null,
      '  ' : null,
    })
  }

  ionViewDidEnter() {
    this.get();
  }

  get() {
    this.CallApi.GetAllProducts().subscribe(data => {
      this.products = data;
      console.log(this.products);
    });
  }

  goCreatePage() {
    console.log("test");
    this.navCtrl.push('CreatePage');
  }

  addToCart() {
    this.CallApi.AddToCart(this.newCart.value)
    .subscribe(data => {
      console.log(this.newCart.value);
      //this.get();
    })
  }
}

