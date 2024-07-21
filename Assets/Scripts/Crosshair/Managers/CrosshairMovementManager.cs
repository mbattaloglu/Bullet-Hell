using Game.Crosshair.Abstracts.Input;
using Game.Crosshair.Concreates.Input;
using Game.Crosshair.Concreates.Movement;
using UnityEngine;

namespace Game.Crosshair.Managers.Movement
{
    public class CrosshairMovementManager : MonoBehaviour
    {
        private ICrosshairInput crosshairInput;
        private ICrosshairMovement crosshairMovement;

        private void Start()
        {
            crosshairInput = new CrosshairMouseInput();
            crosshairMovement = new CrosshairMoveWithTransform(this.transform);
        }

        private void Update()
        {
            Vector2 direction = new Vector2(crosshairInput.Horizontal, crosshairInput.Vertical);

            crosshairMovement.Move(direction);
        }
    }
}