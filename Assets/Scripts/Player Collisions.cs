using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisions : MonoBehaviour
{
    public int life = 3;
    public int apples = 0;
    bool isDead = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.CompareTag("Spike"))
        {
            TakeDamage(3);
        }

        if ( collision.CompareTag("Apple"))
        {
            apples++;
            Destroy(collision.gameObject);
        }

        if ( collision.CompareTag("EndLevel"))
        {
            if (PlayerPrefs.GetInt("MobDestroyed", 0) == 1)
            {
                print("Bravo !");
            }
            else
            {
                print("Il faut detruire le monstre !");
            }
            
        }

    }
    
    
    public void TakeDamage(int damage)
    {
        life -= damage;

         if (life <= 0 && !isDead)
         Die();
    }
    public void Die()
    {
        isDead = true;
        GetComponent<Rigidbody2D>().AddForce(Vector3.up * 150);
        GetComponent<Collider2D>().isTrigger = true;
        Invoke("RestartLevel", 1);
        
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
