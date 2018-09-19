﻿using Assets.Scripts.Player.EnemyStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Character.EnemyStates
{
    public class MeleeState : IEnemyState
    {
        private EnemyBehavior enemy;
        public void Enter(EnemyBehavior enemy)
        {
            enemy.Fighting = true;
            this.enemy = enemy;
        }

        public void Execute()
        {
            if (enemy.RangeInThrow && !enemy.RangeInMeele)
            {
                if (enemy is EnemyFighter)
                {
                    enemy.ChangeState(new PetrolState());
                }
                else if(enemy is EnemyShooter)
                {
                    enemy.ChangeState(new RangeState());
                }
            }

            else if (enemy.Target == null)
                enemy.ChangeState(new IdleState());
        }

        public void Exit()
        {
            enemy.Fighting = false;
        }

        public void OnTrigger(Collider2D other)
        {
            
        }
        public void AttackSword()
        {

        }
    }
}