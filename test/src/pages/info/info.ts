import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { CallApiProvider } from '../../providers/call-api/call-api';
import { FormBuilder, FormGroup } from '@angular/forms';

/**
 * Generated class for the InfoPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-info',
  templateUrl: 'info.html',
})
export class InfoPage {
  id:string;
  student:FormGroup;

  constructor(public navCtrl: NavController, public navParams: NavParams ,public CallApi:CallApiProvider , public fb:FormBuilder) {
    this.student =fb.group({
      'id':null,
      'name': null,
      'age':null,
      'profileImage':null,

    })
  }

  ionViewDidEnter() {
    console.log('ionViewDidLoad InfoPage');
    this.id =this.navParams.get('id');
    this.get();
  }
  get(){
    this.CallApi.GetStudent(this.id).subscribe(data=>{
      this.student.setValue(data);
      console.log(this.student.value);
      
    })
  }
    goUpdatePage(){
this.navCtrl.push('UpdatePage',{student: this.student.value});
    }
  

}
