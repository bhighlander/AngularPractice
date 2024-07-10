import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { RosterService } from '../roster.service';

@Component({
  selector: 'roster-edit-entry',
  templateUrl: './edit-entry.component.html',
  styleUrls: ['./edit-entry.component.css']
})
export class EditEntryComponent implements OnInit {
  public entry: any = {};

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private rosterService: RosterService
  ) { }

  ngOnInit(): void {
    const id = +this.route.snapshot.paramMap.get('id')!;
    this.rosterService.getEntryById(id).subscribe(data => {
      this.entry = data;
    });
  }

  updateEntry(): void {
    const id = +this.route.snapshot.paramMap.get('id')!;
    this.rosterService.updateEntry(id, this.entry).subscribe();
    this.router.navigate(['']);
  }
}
