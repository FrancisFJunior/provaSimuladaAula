using System;

class CartaoInternacional : Cartao{

    private double _FatCredito;
    private double _LimiteDebito;
    private double _LimiteCredito;

    public CartaoInternacional(double limiteCredito, double limiteDebito){
        this._LimiteDebito = limiteDebito;
        this._LimiteCredito = limiteCredito;
    }

    public void Credito(double valor){
        if(_LimiteCredito >= valor){
           _FatCredito += valor;  
           _LimiteCredito -= valor;
        }else{
            Console.WriteLine("Você não possui limite!");
        }
        
    }

    public void Debito(double valor){
        double v = valor * 0.05;
        if(_LimiteDebito >= v){
           _LimiteDebito -= v;
        }else{
            Console.WriteLine("Você não possui limite!");
        }
    }

    
}