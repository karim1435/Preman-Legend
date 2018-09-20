using Assets.Scripts.Character.Helths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Character.Playersd
{
    public class PlayerDeath : Death
    {
        protected override void Dead()
        {
            ToogleScript(false);
        }
    }
}
