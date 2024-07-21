using UnityEngine;

namespace Game.Crosshair.Concreates.Movement
{
    public class CrosshairMoveWithTransform : ICrosshairMovement
    {
        public Transform transform;

        public CrosshairMoveWithTransform(Transform transform)
        {
            this.transform = transform;
        }

        public void Move(Vector2 direction)
        {
            transform.position = new UnityEngine.Vector3(direction.x, direction.y, transform.position.z);
        }
    }
}