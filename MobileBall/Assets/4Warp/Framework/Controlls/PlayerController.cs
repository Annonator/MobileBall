using UnityEngine;

namespace _4Warp.Framework.Controlls
{
    public class PlayerController : MonoBehaviour
    {
        public Vector2 Direction;

        private float Horizontal;

        public float Vertical { get; private set; }

        public void Start()
        {
            this.Direction = new Vector2(.0f, .0f);
        }

        public void Update()
        {
            this.Horizontal = Input.GetAxis("Horizontal");
            this.Vertical = Input.GetAxis("Vertical");
        }
    }
}