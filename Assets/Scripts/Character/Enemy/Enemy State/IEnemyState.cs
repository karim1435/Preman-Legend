using Assets.Scripts.Player.EnemyStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Characterrr.EnemyStates
{
    public interface IEnemyState
    {
        void Enter(EnemyBehavior enemy);
        void Execute();
        void Exit();
        void OnTrigger(Collider2D other);
    }
}
