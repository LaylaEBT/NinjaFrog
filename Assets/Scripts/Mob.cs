using UnityEngine;

public class Mob : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("Contact !");
            PlayerPrefs.SetInt("MobDestroyed", 1);
            Destroy(gameObject);
            
        }
    }
}
