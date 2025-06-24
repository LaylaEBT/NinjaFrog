using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public int life = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.CompareTag("Spike"))
        {
            TakeDamages(3);
        }
    }
    
    public void TakeDamage(int damage)
    {
        life -= damage; 

        Die();
    }
}
