namespace Game.Player.Abstracts.Movement
{
    public interface IPlayerMovement
    {
        float Speed { get; set; }

        void Move(UnityEngine.Vector2 direction);
    }
}