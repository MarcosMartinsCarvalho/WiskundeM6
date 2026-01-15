using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();
            player.coins += 1;
            Debug.Log(player.coins + "coins!");
            Destroy(gameObject);

        }
    }
}
