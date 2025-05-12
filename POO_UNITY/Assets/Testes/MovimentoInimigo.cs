using UnityEngine;

public class MovimentoInimigo : MonoBehaviour
{
    private GameObject _player;
    private Rigidbody _rigidbody;
    private float velocidade;
    private float raioDeVisao = 3;
    void Start()
    {
        _rigidbody = gameObject.gameObject.GetComponent<Rigidbody>();
        velocidade = gameObject.GetComponent<Inimigo>().Velocidade();
        
        _player = GameObject.FindWithTag("Player");
        
        
    }

    
    void Update()
    {
        if (Vector3.Distance(transform.position, _player.transform.position) < raioDeVisao )
        {
            transform.LookAt(_player.transform.position);
        }
        
        
    }
}
