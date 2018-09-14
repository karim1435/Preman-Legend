using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player.EnemyStates
{
    class RangeState : IEnemyState
    {
        private EnemyBehavior enemy;
        public void Enter(EnemyBehavior enemy)
        {
            enemy.Shoot = true;
            this.enemy = enemy;
            
        }
        public void Execute()
        {
            ThrowKnife();

            if (enemy.InMeeleRange)
                enemy.ChangeState(new MeleeState());

            else if (enemy.Target != null)
                enemy.Petrol();
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

        }
    }
}
