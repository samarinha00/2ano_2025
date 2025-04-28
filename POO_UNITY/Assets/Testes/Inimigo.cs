using UnityEngine;

public class Inimigo : Personagem
{
    public enum ArmaDoInimigo
    {
        ESPADA, MACHADO, ADAGA
    }
    
    
    [SerializeField]
    private string armadura;
    [SerializeField]
    private ArmaDoInimigo arma;

    public void AtribuirArmadura(string armadura)
    {
        this.armadura = armadura;
    }

    public string Armadura()
    {
        return this.armadura;
    }

    public void AtribuirArma(ArmaDoInimigo arma)
    {
        this.arma = arma;
    }

    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (arma)
        {
           case ArmaDoInimigo.ESPADA:
               dano = Forca_Ataque() + 10;
               break;
           case ArmaDoInimigo.MACHADO:
               dano = Forca_Ataque() + 18;
               break;
           case ArmaDoInimigo.ADAGA:
               dano = Forca_Ataque() + 5;
               break;
        }
        
        //dano do ataque com a arma
        
        return dano;
    }
    
    
    
    
    
}
