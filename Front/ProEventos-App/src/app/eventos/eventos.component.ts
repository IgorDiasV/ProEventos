import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent {
  public eventos: any = [];
  widthImg: number = 150;
  marginImg: number = 2;
  isCollapsed = true;

  constructor(private http:HttpClient){

  }
  ngOnInit(): void {
    this.getEventos();
  }
  public getEventos(): void{
    this.http.get('http://localhost:5116/api/Evento').subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );
  }
}
