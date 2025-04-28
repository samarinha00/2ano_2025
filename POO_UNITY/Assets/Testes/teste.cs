using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class teste : MonoBehaviour
{
    Carro fusca = new Carro();
    Carro gol = new Carro();
    
    Caminhao caminhao = new Caminhao();
    //=====================================
    
    Personagem joao = new Personagem();
    Inimigo ork = new Inimigo();
    
    void Start()
    {
        fusca.setNome("Fusca de Pai");
        fusca.setCor("Amarelo");
        fusca.setNumero_de_rodas(4);
        fusca.setPreco(2050.90f);
        Debug.Log("0 " + fusca.getNome() + " é " + fusca.getCor() + " tem " + fusca.Numero_de_rodas() + "e custa R$" + fusca.Preco());
        
        gol.setNome("Gol da Mãe");
        gol.setCor("Verde");
        gol.setNumero_de_rodas(4);
        gol.setPreco(3000.00f);
        Debug.Log("0 " + gol.getNome());

        if (fusca.ComparePreco(gol))
        {
            Debug.Log("O Carro " + fusca.getNome() + " é mais caro do que " + gol.getNome());
                
        }
        else
        {
            Debug.Log("O Carro " + fusca.getNome() + " é mais barato do que " + gol.getNome());
        }

        Caminhao.setTipoDeCarroceria("Larga");
        Caminhao.setNumero_de_rodas(8);
        Caminhao.setPreco(6000.00f);
        Caminhao.setCor("Azul");
        Caminhao.setNome("Caminhão da Sam");


        if (fusca.ComparePreco(Caminhao)) ;
        {
            Debug.Log("O Carro " + fusca.getNome() + " é mais caro do que o " + Caminhao.getNome());
        }
        else
        {
            Debug.Log("O Carro " + fusca.getNome() + " é mais barato do que o " + Caminhao.getNome());
        }
        
        //========================================================================================

        joao.AtribuirNome("João Roberto II");
        joao.AtribuirEnergia(10);
        joao.AtribuirForca_Ataque(12);
        joao.AtribuirForca_do_pulo(6);
        joao.AtribuirVelocidade(8);
        joao.AtribuirNumero_de_pes(2);
        joao.AtribuirNumero_de_maos(2);

        
        ork.
        ork.
        ork.
        ork.
        ork.
        ork.

















    }

   
    void Update()
    {
        
    }
}
