using UnityEngine;

[RequireComponent (typeof(Collider2D))]
public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        touchCheck(collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        touchCheck(collision.gameObject);
    }

    private void touchCheck(GameObject go)
    {
        if (!go.CompareTag(Tag.Player)) { return; }
        GameObject.FindAnyObjectByType<GameManager>().BadEnd();
    }
}
