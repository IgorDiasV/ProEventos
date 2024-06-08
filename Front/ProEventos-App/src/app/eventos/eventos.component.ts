import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent {
  public eventos: any = [];
  public eventosFiltrados: any = [];

  widthImg: number = 150;
  marginImg: number = 2;
  isCollapsed: boolean = true;
  private _filtroLista: string  = '';

  public get filtroLista(){
    return this._filtroLista
  }

  public set filtroLista(value: string){
    this._filtroLista = value;
    this.eventosFiltrados = this.filtroLista != '' ? this.filtrarEventos(this.filtroLista) : this.eventos;
  }

  filtrarEventos(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();

    return this.eventos.filter(
      (evento: {
        local: any; tema: string; 
}) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1
      || evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )
  }
  constructor(private http:HttpClient){

  }
  ngOnInit(): void {
    this.getEventos();

    this.eventosFiltrados = this.eventos;
  }
  public getEventos(): void{
    this.http.get('http://localhost:5116/api/Evento').subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );

   
  }
}
