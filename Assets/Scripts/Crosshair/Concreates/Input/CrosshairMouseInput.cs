using Game.Crosshair.Abstracts.Input;
using UnityEngine;

namespace Game.Crosshair.Concreates.Input
{
    public class CrosshairMouseInput : ICrosshairInput
    {
        public float Horizontal
        {
            get
            {
                Vector3 transformed = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition);
                return transformed.x;
            }
        }

        public float Vertical
        {
            get
            {
                Vector3 transformed = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition);
                return transformed.y;
            }
        }
    }
}