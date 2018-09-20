using Assets.Scripts.Character.Playersd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Character.EnemyDeath
{
    public class EnemyDeath : Death
    {
        protected override void Dead()
        {
            ToogleScript(false);
        }
    }
}
