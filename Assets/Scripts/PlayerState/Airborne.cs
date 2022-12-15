using UnityEngine;

namespace PlayerState
{
    public class Airborne : PlayerState
    {
        public void Upwards(Rigidbody2D rb)
        {
            
        }

        public void CollideIn(StatefullMC mc)
        {
            mc.State = new Grounded();
        }

        public void CollideOut(StatefullMC mc)
        {}
    }
}