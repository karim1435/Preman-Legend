using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Player
{
    public class PlayerLongJump:PlayerJump
    {
        private bool canLongJump;
        private bool isLongJump;

        public float longJumpDelay = .15f;
        public float longJumpMultiplier = 1.5f;

        protected override void Update()
        {
            var canJump = inputState.GetButtonValue(inputButtons[0]);
            var holdTime = inputState.GetButtonHoldTime(inputButtons[0]);

            if(!canJump)
            {
                canLongJump = false;
            }
            if(collisionState.Standing && isLongJump)
            {
                isLongJump = false;
            }
            base.Update();

            if(canLongJump&&!collisionState.Standing &&
                holdTime>longJumpDelay)
            {
                OnLongJump();
            }
        }

        private void OnLongJump()
        {
            var vel = body2D.velocity;
            body2D.velocity = new UnityEngine.Vector2(vel.x, jumpSpeed * longJumpMultiplier);
            isLongJump = true;
            canLongJump = false;
        }

        protected override void OnJump()
        {
            base.OnJump();
            canLongJump = true;
        }
    }
}
