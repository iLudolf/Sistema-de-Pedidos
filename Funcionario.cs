using System;

namespace AOP02_Paloma.Funcionarios{

public class Funcionario{
private string nome = " ";
private int matricula = 0;

// public Funcionario(string pNome, int pMatricula){
// this.nome = pNome; 
// this.matricula = pMatricula; 
// } //Construtures

public string getNome(){
        return nome;
    }

public void setNome(string pName){
        this.nome = pName;
    }


    public int getMatricula(){
        return matricula;
    }

public void setMatricula(int pMatricula){
        this.matricula = pMatricula;
    }

  } // class Funcionario
} //namespace 