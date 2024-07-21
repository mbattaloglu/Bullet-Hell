using Game.Player.Abstracts.Movement;

namespace Game.Player.Concreates.Movement
{
    public class PlayerMoveWithRigidbody : IPlayerMovement
    {
        public UnityEngine.Rigidbody2D Rigidbody { get; }

        public float Speed { get; set; }

        public PlayerMoveWithRigidbody(UnityEngine.Rigidbody2D rigidbody, float speed)
        {
            Speed = speed;
            Rigidbody = rigidbody;
        }

        public void Move(UnityEngine.Vector2 direction)
        {
            Rigidbody.velocity = new UnityEngine.Vector2(direction.x * Speed, direction.y * Speed);
        }
    }
}