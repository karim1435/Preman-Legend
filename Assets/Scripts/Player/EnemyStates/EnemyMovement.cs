using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Player.EnemyStates
{
    public class EnemyMovement:MonoBehaviour
    {
        [SerializeField]
        private Transform rightEdge;
        [SerializeField]
        private Transform leftEdge;
        private float moveSpeed;
        private Enemy enemy;
        private EnemyAttack enemyAttack;
        public GameObject Target { get { return enemyAttack.Target; } }

        public Rigidbody2D Body2D { get; private set; }

        void Start()
        {
            enemyAttack = GetComponent<EnemyAttack>();
            enemy = GetComponent<Enemy>();
            moveSpeed = enemy.MoveSpeed;
            Body2D = GetComponent<Rigidbody2D>();
        }
       
        public void Move()
        {
            var tempSpeed = moveSpeed;
            var velX = tempSpeed * (float)enemy.Dir;
            Body2D.velocity = new Vector2(velX, Body2D.velocity.y);

        }
        public bool ClampByEdge()
        {
            var rightEdge = ((float)enemy.Dir > 0 && transform.position.x < this.rightEdge.position.x);
            var leftEdge = ((float)enemy.Dir < 0 && transform.position.x > this.leftEdge.position.x);
            return rightEdge || leftEdge;
        }
        public void LookAtTarget()
        {
            if (Target != null)
            {
                float xDir = Target.transform.position.x - transform.position.x;
                bool inLeft = xDir < 0 && enemy.Dir == Direction.Right;
                bool inRight = xDir > 0 && enemy.Dir != Direction.Right;
                if (inLeft || inRight)
                {
                    ToogleDirection();
                }
            }
        }
        public void ToogleDirection()
        {
            enemy.Dir = enemy.Dir == Direction.Right ? Direction.Left : Direction.Right;
            enemy.ChangeDirection();
        }
    }
}
