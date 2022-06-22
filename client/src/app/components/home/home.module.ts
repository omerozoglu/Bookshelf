import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { StatisticsComponent } from './statistics/statistics.component';
import { BookshelfComponent } from './bookshelf/bookshelf.component';
import { BookaddingComponent } from './bookadding/bookadding.component';
import { HomeComponent } from './home.component';


@NgModule({
  declarations: [
    StatisticsComponent,
    BookshelfComponent,
    BookaddingComponent,
    HomeComponent
  ],
  imports: [
    CommonModule,
    HomeRoutingModule
  ]
})
export class HomeModule { }
