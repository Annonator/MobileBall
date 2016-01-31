using System.Collections;

using UnityEngine;

namespace _4Warp.Framework.Controlls
{
    public class PlayerController : MonoBehaviour
    {
        public Vector2 Direction;

        public void Start()
        {
            this.Direction = new Vector2(.0f, .0f);
        }

        public void Update()
        {
        }
    }
}