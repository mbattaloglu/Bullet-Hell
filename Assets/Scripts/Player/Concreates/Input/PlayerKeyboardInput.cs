using Game.Player.Abstracts.Input;

namespace Game.Player.Concreates.Input
{
    public class PlayerKeyboardInput : IPlayerInput
    {
        public float Horizontal => UnityEngine.Input.GetAxisRaw("Horizontal");
        public float Vertical => UnityEngine.Input.GetAxisRaw("Vertical");
    }
}