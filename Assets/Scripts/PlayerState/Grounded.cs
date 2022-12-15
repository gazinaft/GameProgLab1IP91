using UnityEngine;

namespace PlayerState
{
    public class Grounded : PlayerState
    {
        private static float jump = 10f;
        public void Upwards(Rigidbody2D rb)
        {
            rb.velocity = new Vector2 (rb.velocity.x, jump);
        }

        public void CollideIn(StatefullMC mc)
        {
        }

        public void CollideOut(StatefullMC mc)
        {
            mc.State = new Airborne();
        }

    }
}