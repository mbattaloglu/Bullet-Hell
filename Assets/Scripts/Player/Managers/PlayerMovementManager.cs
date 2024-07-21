using Game.Player.Abstracts.Input;
using Game.Player.Abstracts.Movement;
using Game.Player.Concreates.Input;
using Game.Player.Concreates.Movement;
using UnityEngine;

namespace Game.Player.Managers.Movement
{
    public class PlayerMovementManager : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D rb;

        [SerializeField]
        private float speed;

        private IPlayerInput playerInput;
        private IPlayerMovement playerMovement;

        private Vector2 direction;

        private void Start()
        {
            playerInput = new PlayerKeyboardInput();
            playerMovement = new PlayerMoveWithRigidbody(rb, speed);
        }

        private void Update()
        {
            direction = new Vector2(playerInput.Horizontal, playerInput.Vertical).normalized;
        }

        private void FixedUpdate()
        {
            playerMovement.Move(direction);
        }
    }
}