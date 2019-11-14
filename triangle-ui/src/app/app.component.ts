import { Component } from '@angular/core';
import { TriangleService } from './services/triangle.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { debug } from 'util';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'triangle-ui';
  coordinates: string;
  rowColumn: string;
  coordinatesMessage: string;
  triangleMessage: string;

  rowColumnForm = new FormGroup({
    row: new FormControl('', [Validators.required]),
    column: new FormControl('', [Validators.required, Validators.max(12)])
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
    this.resetErrorMessages();

    const topLeft = this.coordinatesForm.get('topLeft').value;
    const bottomRight = this.coordinatesForm.get('bottomRight').value;
    const bottomLeft = this.coordinatesForm.get('bottomLeft').value;

    if (topLeft === '') {
      this.triangleMessage = 'Top Left coordinate missing';
      return;
    }
    if (bottomRight === '') {
      this.triangleMessage = 'Bottom Right coordinate missing';
      return;
    }
    if (bottomLeft === '') {
      this.triangleMessage = 'Bottom Left coordinate missing';
      return;
    }

    const coordinates = topLeft + '=' + bottomRight + '=' + bottomLeft;
    this.service.getTriangle(coordinates)
      .subscribe(data => this.rowColumn = data);

  }

  resetErrorMessages() {
    this.triangleMessage = '';
    this.coordinatesMessage = '';
  }

  get row() { return this.rowColumnForm.get('row'); }
  get column() { return this.rowColumnForm.get('column'); }

  get topLeft() { return this.coordinatesForm.get('topLeft').value; }
  get bottomRight() { return this.coordinatesForm.get('bottomRight').value; }
  get bottomLeft() { return this.coordinatesForm.get('bottomLeft').value; }


}
