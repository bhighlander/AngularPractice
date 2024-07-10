import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { EditEntryComponent } from './edit-entry/edit-entry.component';



const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'edit/:id', component: EditEntryComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
