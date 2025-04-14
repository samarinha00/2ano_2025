using UnityEngine;

public class teste : MonoBehaviour
{
    Carro fusca = new Carro();
    Carro gol = new Carro();
    
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
        
        
    }

   
    void Update()
    {
        
    }
}
