using Assets.Scripts.Characterrr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Weapon
{
    public interface IShoot
    {
        void InitializeDirection(Direction dir);
    }
}
