import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarComponent } from './nav-bar/nav-bar.component';



@NgModule({
  declarations: [NavBarComponent],
  imports: [
    CommonModule
  ],
  // export NavBarComponent so we can use it in another module
  exports: [NavBarComponent],
})
export class CoreModule { }
