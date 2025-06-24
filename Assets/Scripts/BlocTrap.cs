using UnityEngine;

public class BlocTrap : MonoBehaviour
{
    public GameObject connectedBloc;
    public Collider2D colliderToActivate;
    
    void Start()
    {
        Destroy(gameObject.GetComponent<SpriteRenderer>());
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            connectedBloc.AddComponent<Rigidbody2D>();
            colliderToActivate.enabled = true;
            Destroy(gameObject);
        }
    }

    
}
