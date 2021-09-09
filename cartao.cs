using System;

class Cartao {
    private int _IdCliente;
    private int _NumeroCartao;
    private bool faturaPaga;

    public Cartao(int idC, int nCartao){
        this._IdCliente = idC;
        this._NumeroCartao = nCartao;
    }
    
    public void FecharFatura(double cartao, bool fPaga){
        double fatura = cartao;
        faturaPaga = fPaga;

    }

    public void Compra(double valor, int tipo){
        if(tipo == 1){
            Credito(valor);
        }
    }


    
}