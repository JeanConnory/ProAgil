export interface Lote {
    id: number; 
    nome: string; 
    preco: number; 
    daDataInicio: Date;
    daDataFim: Date; 
    quantidade: number;
    eventoId: number;
}