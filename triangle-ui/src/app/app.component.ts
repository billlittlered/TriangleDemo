import { Component } from '@angular/core';
import { TriangleService } from './services/triangle.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'triangle-ui';
  coordinates: string;
  rowColumn: string;

  rowColumnForm = new FormGroup({
    row: new FormControl('', [Validators.required]),
    column: new FormControl('', [Validators.required])
  });

  coordinatesForm = new FormGroup({
    topLeft: new FormControl('', [Validators.required]),
    bottomRight: new FormControl('', [Validators.required]),
    bottomLeft: new FormControl('', [Validators.required])
  });

  constructor(private service: TriangleService) {
  }

  getCoordinates() {
    const tmpRow = this.rowColumnForm.get('row').value;
    const tmpColumn = Number(this.rowColumnForm.get('column').value);

    this.service.getCoordinates(tmpRow, tmpColumn)
      .subscribe(data => this.coordinates = data);
  }

  getTriangle() {
    const topLeft = this.coordinatesForm.get('topLeft').value;
    const bottomRight = this.coordinatesForm.get('bottomRight').value;
    const bottomLeft = this.coordinatesForm.get('bottomLeft').value;

    const coordinates = topLeft + '=' + bottomRight + '=' + bottomLeft;
    this.service.getTriangle(coordinates)
      .subscribe(data => this.rowColumn = data);

  }

  get row() { return this.rowColumnForm.get('row'); }
  get column() { return this.rowColumnForm.get('column'); }

  get topLeft() { return this.coordinatesForm.get('topLeft').value; }
  get bottomRight() { return this.coordinatesForm.get('bottomRight').value; }
  get bottomLeft() { return this.coordinatesForm.get('bottomLeft').value; }


}
