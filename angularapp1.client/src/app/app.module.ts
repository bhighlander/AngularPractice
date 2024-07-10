import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { provideHttpClient, withFetch, HttpClientModule } from '@angular/common/http';
import { EditEntryComponent } from './edit-entry/edit-entry.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    EditEntryComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, AppRoutingModule, FormsModule
  ],
  providers: [
    provideHttpClient(
      withFetch()
    ),
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
