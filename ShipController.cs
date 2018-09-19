using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public enum WeaponType
{
    Missile,
    Bullet
}
public enum Flame
{
    Blue,
    Red
}

public class ShipController : MonoBehaviour
{
    #region variables
    public WeaponType weaponType;
    public Flame flameColor;

    private IWeapon weapon;
    private IFlame iFlame;
    #endregion

    private void HandleWeaponType()
    {

    }
}
