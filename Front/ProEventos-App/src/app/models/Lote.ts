import { Evento } from "./Evento";

export interface Lote {
    Id : number;
    Nome : string;
    Preco : number;
    DataInicio?: Date;
    DataFim?: Date;
    Quantiade : number;
    Evento : Evento;
}
