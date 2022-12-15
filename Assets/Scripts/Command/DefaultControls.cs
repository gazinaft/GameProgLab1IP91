using UnityEngine;

namespace Command
{
    public class DefaultControls : Controls
    {
        private float moveVelocity = 10f;

        public DefaultControls(float speed)
        {
            moveVelocity = speed;
        }
        public void Right(Rigidbody2D rb)
        {
            rb.velocity = new Vector2 (moveVelocity, rb.velocity.y);       
        }

        public void Left(Rigidbody2D rb)
        {
            rb.velocity = new Vector2(-moveVelocity, rb.velocity.y);
        }

        public void Stop(Rigidbody2D rb)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }
}