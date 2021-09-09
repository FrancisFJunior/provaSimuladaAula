using System;

class Cliente {
    private int _Id;
    private string _Nome;
    private int _Cpf;

    public Cliente (int id, string nome, int cpf){
        this._Id = id;
        this._Nome = nome;
        this._Cpf = cpf;
    }
    
    public string getId()
  {
    return _Id;
  } 

  public string getNome()
  {
    return _Nome;
  } 

  public string getCpf()
  {
    return _Cpf;
  }
}