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


        ork.AtribuirNome("Ork Gob");
        ork.AtribuirEnergia(23);
        ork.AtribuirForca_Ataque(15);
        ork.AtribuirForca_do_pulo(8);
        ork.AtribuirVelocidade(6);
        ork.AtribuirNumero_de_pes(2);
        ork.AtribuirNumero_de_maos(4);
        ork.AtribuirArma(Inimigo.ArmaDoInimigo.MACHADO);
        ork.AtribuirArmadura(Inimigo.ArmaduraDoInimigo.COURO);
        
        if (ork.DanoDoInimigo() >= joao.Energia())
        {
            Debug.Log("0" + joao.Nome() + "ficou sem energia");
        }
        else
        {
            Debug.Log("0" + joao.Nome() + "ainda tem" + joao.Energia() + "energia");
        }
















    }

   
    void Update()
    {
        
    }
}
