using UnityEngine;
using System.Collections;
using System;

namespace Assets.Scripts.Characterrr{
    public class PlayerMovement : AbstractBehavior{

        private float moveSpeed;
        private float absVelX;
        private float absVelY;

        private Player player;
        private FaceDirection facingDir;

        public float AbsvelX { get { return absVelX; } }
        public float AbsVely { get { return absVelY; } }
        void Start()
        {
            facingDir = GetComponent<FaceDirection>();
            player = GetComponent<Player>();

            moveSpeed = player.MoveSpeed;
        }
        protected void FixedUpdate()
        {
            HandleMovement();
            GetPosition();
        }

        private void GetPosition()
        {
            absVelX = Math.Abs(body2D.velocity.x);
            absVelY = Math.Abs(body2D.velocity.y);
        }

        void HandleMovement()
        {
            var right = inputState.GetButtonValue(inputButtons[0]);
            var left = inputState.GetButtonValue(inputButtons[1]);

            if (right || left)
                Move();
        }

        private void Move()
        {
            var tempSpeed = moveSpeed;
            var velX = tempSpeed * (float)player.Dir;
            body2D.velocity = new Vector2(velX, body2D.velocity.y);
        }
    }
}
