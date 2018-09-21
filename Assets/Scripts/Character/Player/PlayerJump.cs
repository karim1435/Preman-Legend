using Assets.Scripts.Characterrr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Player
{
   public class PlayerJump:AbstractBehavior
    {
        [SerializeField]
        protected float jumpSpeed;
        public float jumpDelay = .2f;
        public int jumpCount = 2;

        protected float lastJumpTime;
        protected int jumpsRemaining;

        protected virtual void Update()
        {
            HandleJump();
        }
        void HandleJump()
        {
            var canJump = inputState.GetButtonValue(inputButtons[0]);
            var holdTime = inputState.GetButtonHoldTime(inputButtons[0]);

            if(collisionState.Standing)
            {
                if (canJump && holdTime < .1f)
                {
                    jumpsRemaining = jumpCount - 1;
                    OnJump();
                }
            }
            else
            {
                if(canJump && holdTime<.1f &&
                    Time.time - lastJumpTime > jumpDelay)
                {
                    PrepareLongJump();
                }

            }
        }

        private void PrepareLongJump()
        {
            if(jumpsRemaining>0)
            {
                OnJump();
                jumpsRemaining--;
            }
        }

        protected virtual void OnJump()
        {
            var vel = body2D.velocity;
            body2D.velocity = new Vector2(vel.x, jumpSpeed);
        }
    }
}
