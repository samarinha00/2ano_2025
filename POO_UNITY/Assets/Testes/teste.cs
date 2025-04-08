using UnityEngine;

public class teste : MonoBehaviour
{
    carro fusca = new carro();
    
    void Start()
    {
        fusca.setNome("Fusca de Pai");
        fusca.setCor("Verde");
        
        Debug.Log("0 " + fusca.getNome() + " é " + fusca.getCor());
    }

   
    void Update()
    {
        
    }
}
