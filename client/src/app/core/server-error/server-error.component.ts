import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-server-error',
  templateUrl: './server-error.component.html',
  styleUrls: ['./server-error.component.scss']
})
export class ServerErrorComponent implements OnInit {
  error:any;
  constructor(private router:Router) {
          let navigation = this.router.getCurrentNavigation();
          this.error = navigation?.extras?.state?.error ?? " - ";
         //this.error = this.router.getCurrentNavigation()?.extras?.state?.error ?? 'سيد يا سيد';

    // this.error =
    //   navigation &&
    //   navigation.extras &&
    //   navigation.extras.state &&
    //   navigation.extras.state.error;

  }

  ngOnInit(): void {
    // this.error = history.state.error;

     console.log(this.error);
  }

}
