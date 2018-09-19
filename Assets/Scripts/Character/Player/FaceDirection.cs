using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Character
{
    public class FaceDirection:AbstractBehavior
    {
        private Player player;
        void Start()
        {
            player = GetComponent<Player>();
        }
        void Update()
        {
            HandleFaceDirection();
        }
        private void HandleFaceDirection()
        {
            var right = inputState.GetButtonValue(inputButtons[0]);
            var left = inputState.GetButtonValue(inputButtons[1]);

            if (right)
                player.Dir = Direction.Right;
            else if (left)
                player.Dir = Direction.Left;
            player.ChangeDirection();
        }
        
    }
}
