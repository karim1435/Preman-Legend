﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Characterrr.EnemyStates
{
    public abstract class EnemyBehavior : MonoBehaviour
    {
        public delegate void EnemyBehave();

        public event EnemyBehave OnLookTarget;
        public event EnemyBehave OnEnemyMove;
        public event EnemyBehave OnChangeDirection;

        private IEnemyState currentState;
        private EnemyAttack enemyAttack;
        private EnemyMovement enemyMovement;
        private EnemyHealth enemyStatusHealth;

        public bool Idle { get; set; }
        public bool Petrolling { get; set; }
        public bool Shoot { get; set; }
        public bool Fighting { get; set; }
        public GameObject Target { get { return enemyAttack.Target; } set { enemyAttack.Target = value; } }
        public Rigidbody2D Body2D { get; set; }
        public bool RangeInThrow { get { return enemyAttack.InThrowRange; } }
        public bool RangeInMeele { get { return enemyAttack.InMeeleRange; } }
        protected void Start()
        {
            enemyMovement = GetComponent<EnemyMovement>();
            enemyAttack = GetComponent<EnemyAttack>();
            enemyStatusHealth = GetComponent<EnemyHealth>();
            Body2D = GetComponent<Rigidbody2D>();
            ChangeState(new IdleState());
        }
        void Update()
        {
            currentState.Execute();

            if (Idle || Fighting || enemyStatusHealth.Die)
                Body2D.velocity = Vector2.zero;

            if (!ReferenceEquals(OnLookTarget, null))
                OnLookTarget();
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
            if (enemyMovement.onTheEdge)
                Move();
            else
            {
                Target = null;
                TurnEdgeBack();
            }
        }
        protected void TurnEdgeBack()
        {
            if (!ReferenceEquals(OnChangeDirection, null))
                OnChangeDirection();
            ChangeState(new PetrolState());

        }
        protected void Move()
        {
            if (!Fighting && !Idle || !Shoot)
            {
                if(!ReferenceEquals(OnEnemyMove,null))
                    OnEnemyMove();
            }
        }
       
    }

}

