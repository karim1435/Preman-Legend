using Assets.Scripts.Player.EnemyStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Character.EnemyStates
{
    class RangeState : IEnemyState
    {
        private EnemyBehavior enemy;

        private float throwTimer;
        private float throwCoolDown = 3;
        public void Enter(EnemyBehavior enemy)
        {
            this.enemy = enemy;
        }
        public void Execute()
        {
            if (enemy.RangeInMeele && enemy is EnemyFighter)
                enemy.ChangeState(new MeleeState());

            else if (enemy.Target != null)
            {
                if(enemy is EnemyFighter)
                {
                    enemy.Petrol();
                }
                else if (enemy is EnemyShooter)
                {
                    enemy.Shoot = true;
                    ThrowKnife();      
                }
            }

            else
                enemy.ChangeState(new IdleState());
        }

        public void Exit()
        {
            enemy.Shoot = false;
        }
        public void OnTrigger(Collider2D other)
        {

        }
        public void ThrowKnife()
        {

            enemy.Body2D.velocity = Vector2.zero;

        }
    }
}