using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player.EnemyStates
{
    public class EnemyBehavior : MonoBehaviour
    {

        private IEnemyState currentState;
        
        private EnemyRange enemyRange;
        private EnemyAttack enemyAttack;
        private EnemyMovement enemyMovement;
        private EnemyHealth enemyStatusHealth;
        private Enemy enemy;
        public bool Idle { get; set; }
        public bool Petrolling { get; set; }
        public bool Shoot { get; set; }
        public bool Fighting { get; set; }
        public GameObject Target { get { return enemyAttack.Target; } }
        public Rigidbody2D Body2D { get; set; }
        public bool RangeInThrow { get { return enemyAttack.InThrowRange; } }
        public bool RangeInMeele { get { return enemyAttack.InMeeleRange; } }
        private float GetDistance(GameObject from, GameObject to)
        {
            return Vector2.Distance(from.transform.position, to.transform.position);
        }
        void Start()
        {
            Body2D = GetComponent<Rigidbody2D>();
            enemyMovement = GetComponent<EnemyMovement>();
            enemyAttack = GetComponent<EnemyAttack>();
            enemy = GetComponent<Enemy>();
            enemyStatusHealth = GetComponent<EnemyHealth>();

            ChangeState(new IdleState());
        }
        void FixedUpdate()
        {
            if (enemyStatusHealth.die)
                return;

            currentState.Execute();

            if(Idle||Fighting)
                Body2D.velocity = Vector2.zero;

            enemyMovement.LookAtTarget();
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
            if (enemyMovement.ClampByEdge())
                Move();
            else
                TurnEdgeBack();
        }
        private void TurnEdgeBack()
        {
            Body2D.velocity = Vector2.zero;
            if (currentState is PetrolState)
                enemyMovement.ToogleDirection();
        }
        private void Move()
        {
            if(!Fighting&&!Idle)
            {
                enemyMovement.Move();
            }
        }
    }
}
