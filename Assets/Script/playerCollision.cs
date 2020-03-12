using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("hit " + collisionInfo.collider.name);

        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle --> Lose");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}