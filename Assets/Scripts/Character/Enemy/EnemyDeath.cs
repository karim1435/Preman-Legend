using Assets.Scripts.Characterrr.Playersd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Characterrr.EnemyDeath
{
    public class EnemyDeath : Death
    {
        protected override void Dead()
        {
            ToogleScript(false);
        }
    }
}
