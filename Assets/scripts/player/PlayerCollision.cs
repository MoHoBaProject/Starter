using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag($"Obstacle"))
        {
            Debug.Log(collisionInfo.collider.name);
        }
    }
}