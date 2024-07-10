import { Component } from "@angular/core";
import { RosterService } from "./roster.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

export class AppComponent {
  constructor(private rosterService: RosterService) { }

  ngOnInit(): void {
    this.rosterService.getRoster();
  }
}
