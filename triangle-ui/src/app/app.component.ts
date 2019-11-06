import { Component } from '@angular/core';
import { TriangleService } from './services/triangle.service';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'triangle-ui';
  coordinates: string;
  rowColumnForm = new FormGroup({
    row: new FormControl(''),
    column: new FormControl('')
  });

  constructor(private service: TriangleService) {
  }

  getCoordinates() {
    const tmpRow = this.rowColumnForm.get('row').value;
    const tmpColumn = Number(this.rowColumnForm.get('column').value);
    this.service.getCoordinates(tmpRow, tmpColumn)
      .subscribe(data => this.coordinates = data);
  }


}
