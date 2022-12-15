using UnityEngine;

namespace PlayerState
{
    public interface PlayerState
    {
        void Upwards(Rigidbody2D rb);
        void CollideIn(StatefullMC mc);
        void CollideOut(StatefullMC mc);
    }
}