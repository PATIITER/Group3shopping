import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { FormBuilder, FormGroup, RequiredValidator, Validators } from '@angular/forms';
import { CallApiProvider } from '../../providers/call-api/call-api';

/**
 * Generated class for the CreatePage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-create',
  templateUrl: 'create.html',
})
export class CreatePage {
  newStudent: FormGroup;
  constructor(public navCtrl: NavController, public navParams: NavParams, public fb: FormBuilder, public CallApi: CallApiProvider) {
    this.newStudent = fb.group({
      'id': null,
      'name': [null,Validators.required],
      'age': [null,Validators.required],
      'profileImage': [null,Validators.required],

    })
  }

  ionViewDidEnter() {
    console.log('ionViewDidLoad CreatePage');
  }

  create() {
this.CallApi.CreateStudent(this.newStudent.value)
      .subscribe(data => {
        console.log("Create.");
        this.navCtrl.pop();

      });


  }

}
