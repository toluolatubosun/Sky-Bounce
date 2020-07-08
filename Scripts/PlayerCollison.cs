using UnityEngine.UI;
using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().gameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
    }
}
