using Assets.Scripts.Characterrr.Helths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Characterrr.Playersd
{
    public class PlayerDeath : Death
    {
        protected override void Dead()
        {
            ToogleScript(false);
        }
    }
}
