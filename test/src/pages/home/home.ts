import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { CallApiProvider } from '../../providers/call-api/call-api';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  students: any;

  constructor(public navCtrl: NavController, public CallApi: CallApiProvider) {

  }

  ionViewDidEnter() {
    this.get();
  }

  get() {
    this.CallApi.GetAllStudent().subscribe(data => {
      this.students = data;
      console.log(this.students);
    });
  }
  goInfoPage(id: string) {
    console.log("go");
    this.navCtrl.push('InfoPage', { id: id });
  }
  goCreatePage() {
    console.log("test");

    this.navCtrl.push('CreatePage');
  }
  delete(id :string){
        this.CallApi.DeleteStudent(id)
        .subscribe(data=>{
            console.log("Delete.");
            this.get();
            

        })

  }
}
