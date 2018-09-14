using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player.EnemyStates
{
    class PetrolState : IEnemyState
    {
        private float petrolTimer;
        private float petrolDuration=5f;

        private EnemyBehavior enemy;
        public void Enter(EnemyBehavior enemy)
        {
            enemy.Petrolling = true;
            this.enemy = enemy;
        }
        public void Execute()
        {
            Petrol();
            enemy.Petrol();
            if (enemy.Target != null && enemy.RangeInThrow)
                enemy.ChangeState(new RangeState());
        }
        private void Petrol()
        {
            petrolTimer += Time.deltaTime;
            if (petrolTimer>=petrolDuration)
                enemy.ChangeState(new IdleState());
        }

        public void Exit()
        {
            enemy.Petrolling = false;
        }

        public void OnTrigger(Collider2D other)
        {
        }
    }
}
