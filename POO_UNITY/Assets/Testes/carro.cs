using UnityEngine;

public class Carro
{
    private string nome;
    private int numero_de_rodas;
    private string cor;
    private float preco;

    public string getNome()
    {
        return nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }
    
    public string getCor()
    {
        return nome;
    }
    
    public void setCor(string cor)
    {
        this.cor = cor;
    }
    

    public void setNumero_de_rodas(int numero_de_rodas)
    {
        this.numero_de_rodas = numero_de_rodas;
    }
    
    public int Numero_de_rodas()
    {
        return this.numero_de_rodas;
    }

    public void setPreco(float preco)
    {
        this.preco = preco;
    }

    public float Preco()
    {
        return this.preco;
    }

    public bool ComparePreco(Carro carro)
    {
        if (this.preco > carro.Preco())
        {
            return true;
        }
        return false;
    }
    
}
