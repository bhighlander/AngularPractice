import { Component, OnInit } from '@angular/core';
import { RosterService } from '../roster.service';
import { Router } from '@angular/router';

@Component({
  selector: 'roster-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public rosterData: any;

  constructor(private rosterService: RosterService, private router: Router) { }

  ngOnInit(): void {
    this.rosterService.getRoster().subscribe(data => {
      this.rosterData = data;
    });
  }

  editEntry(id: number): void {
    this.router.navigate(['/edit', id]);
  }
}
