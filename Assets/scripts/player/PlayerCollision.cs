using UnityEngine;

namespace player
{
    public class PlayerCollision : MonoBehaviour
    {
        public PlayerMovement movement;

        private void OnCollisionEnter(Collision collisionInfo)
        {
            if (collisionInfo.collider.CompareTag($"Obstacle"))
            {
                Debug.Log(collisionInfo.collider.name);
                movement.enabled = false;
            }
        }
    }
}