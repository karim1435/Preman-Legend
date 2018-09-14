using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player.EnemyStates
{
    public class EnemyBehavior : MonoBehaviour
    {
        [SerializeField]
        private Transform rightEdge;
        [SerializeField]
        private Transform leftEdge;

        private IEnemyState currentState;
        private float meleeRange;
        private float throwRange;
        private Enemy enemy;
        private EnemyRange enemyRange;
        private float moveSpeed;
        private GameObject target;
        private EnemyHealth enemyStatusHealth;
        public bool Idle { get; set; }
        public bool Petrolling { get; set; }
        public bool Shoot { get; set; }
        public bool Fighting { get; set; }
        public GameObject Target { get { return target; } }
        public Rigidbody2D Body2D { get; set; }
        public bool InThrowRange
        {
            get
            {
                if (target != null)
                    return GetDistance(gameObject, target) <= throwRange;

                return false;
            }
        }
        public bool InMeeleRange
        {
            get
            {
                if(target!=null)
                    return GetDistance(gameObject,target) <= meleeRange;

                return false;
            }
        }
        private float GetDistance(GameObject from, GameObject to)
        {
            return Vector2.Distance(from.transform.position, to.transform.position);
        }
        void Start()
        {
           
            Body2D = GetComponent<Rigidbody2D>();

            enemy = GetComponent<Enemy>();
            throwRange = enemy.ThrowRange;
            meleeRange = enemy.MeeleRange;
            moveSpeed = enemy.MoveSpeed;
            
            enemyRange = FindObjectOfType<EnemyRange>();
            enemyRange.InRange += TargetAttack;
            enemyStatusHealth = GetComponent<EnemyHealth>();

            ChangeState(new IdleState());
        }
        private void LookAtTarget()
        {
            if (target != null)
            {
                float xDir = target.transform.position.x - transform.position.x;
                bool inLeft = xDir < 0 && enemy.Dir == Direction.Right;
                bool inRight = xDir > 0 && enemy.Dir != Direction.Right;
                if (inLeft ||  inRight)
                {
                    ToogleDirection();
                }
            }
        }
        void OnDisable()
        {
            enemyRange.InRange -= TargetAttack;
        }
        void FixedUpdate()
        {
            if (enemyStatusHealth.die)
                return;

            currentState.Execute();

            if(Idle||Fighting)
                Body2D.velocity = Vector2.zero;

            LookAtTarget();
        }
        public void ChangeState(IEnemyState newState)
        {
            if (currentState != null)
                currentState.Exit();

            currentState = newState;
            currentState.Enter(this);
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            currentState.OnTrigger(other);
        }
        public void Petrol()
        {
            if (ClampByEdge())
                Move();
            else
                TurnEdgeBack();
        }
        private void TurnEdgeBack()
        {
            Body2D.velocity = Vector2.zero;
            if (currentState is PetrolState)
                ToogleDirection();
        }

        private void Move()
        {
           
            if(!Fighting&&!Idle)
            {
                var tempSpeed = moveSpeed;
                var velX = tempSpeed * (float)enemy.Dir;
                Body2D.velocity = new Vector2(velX, Body2D.velocity.y);
            }
            
        }
        private bool ClampByEdge()
        {
            var rightEdge = ((float)enemy.Dir > 0 && transform.position.x < this.rightEdge.position.x);
            var leftEdge = ((float)enemy.Dir < 0 && transform.position.x > this.leftEdge.position.x);
            return rightEdge || leftEdge;
        }
        private void ToogleDirection()
        {
            enemy.Dir = enemy.Dir == Direction.Right ? Direction.Left : Direction.Right;
            enemy.ChangeDirection();
        }
        private void TargetAttack(GameObject other)
        {
            target = other;
        }
    }
}
