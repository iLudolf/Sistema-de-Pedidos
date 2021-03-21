using System;

namespace AOP02_Paloma.Funcionarios{

public class Funcionario{
public static string nome = "admin";
public static int matricula = 0;


public Funcionario(string pNome, int pMatricula){
nome = pNome; 
matricula = pMatricula; 
} //Construtures

public string getNome(){
        return nome;
    }

public void setNome(string pName){
        nome = pName;
    }


    public int getMatricula(){
        return matricula;
    }

public void setMatricula(int pMatricula){
        matricula = pMatricula;
    }

  } // class Funcionario
} //namespace 