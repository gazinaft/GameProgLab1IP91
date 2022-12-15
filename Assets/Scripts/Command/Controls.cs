using UnityEngine;

namespace Command
{
    public interface Controls
    {
        void Right(Rigidbody2D rb);
        void Left(Rigidbody2D rb);
        void Stop(Rigidbody2D rb);
    }
}