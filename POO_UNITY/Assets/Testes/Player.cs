using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    public float velocidade = 10;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        Vector3 posicao = transform.position;
        
        
        //esquerda X-
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(" " + posicao.x);
            posicao.x = posicao.x - velocidade * Time.deltaTime;

        }

        //direita X+
        if (Input.GetKeyDown(KeyCode.B))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
        }    
        
        //cima Z+
        if (Input.GetKeyDown(KeyCode.C))
        {
            posicao.z = posicao.z + velocidade * Time.deltaTime;
        }
        
        //baixo Z-
        if (Input.GetKeyDown(KeyCode.D))
        {
            posicao.z = posicao.z - velocidade * Time.deltaTime;
        }    
        
        transform.position = posicao;
        
        
        
        
        
    }
}
