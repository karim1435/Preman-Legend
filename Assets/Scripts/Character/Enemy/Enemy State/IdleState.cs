using Assets.Scripts.Player.EnemyStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Character.EnemyStates
{
    class IdleState : IEnemyState
    {
        private float idleTimer;
        private float idleDuration=2f;
        private EnemyBehavior enemy;
        public void Enter(EnemyBehavior enemy)
        {
            enemy.Idle = true;
            this.enemy = enemy;
        }
        public void Execute()
        {
            Idle();

            if(enemy.Target!=null)
                enemy.ChangeState(new PetrolState());
        }

        public void Exit()
        {
            enemy.Idle = false; 
        }

        public void OnTrigger(Collider2D other)
        {
            if(other.tag=="Knife")
            {
                enemy.Target = Player.Instance.gameObject;
            }
        }
        private void Idle()
        {
            idleTimer += Time.deltaTime;
            if (idleTimer>=idleDuration)
            {
                enemy.ChangeState(new PetrolState());
            }
        }
    }
}
