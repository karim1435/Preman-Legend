using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player.EnemyStates
{
    public interface IEnemyState
    {
        void Enter(EnemyBehavior enemy);
        void Execute();
        void Exit();
        void OnTrigger(Collider2D other);
    }
}
