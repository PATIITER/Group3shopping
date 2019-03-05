import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CallApiProvider } from '../../providers/call-api/call-api';

/**
 * Generated class for the UpdatePage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-update',
  templateUrl: 'update.html',
})
export class UpdatePage {
  newStudent: FormGroup

  constructor(public navCtrl: NavController, public navParams: NavParams ,public fb: FormBuilder, public CallApi: CallApiProvider) {
    // this.newStudent = fb.group({
    //   'id': null,
    //   'name': [null,Validators.required],
    //   'age': [null,Validators.required],
    //   'profileImage':[null,Validators.required],

    // })
  }

  ionViewDidEnter() {
    console.log('ionViewDidLoad UpdatePage');
    // let oldStudent =this.navParams.get('student');
    // this.newStudent.setValue(oldStudent);
    // console.log(this.newStudent.value);
    
  }
  // update(){
  // this.CallApi.UpdateStudent(this.newStudent.value)
  //     .subscribe(data => {
  //       console.log("update.");
  //       this.navCtrl.pop();

  //     });
  //   }
}
