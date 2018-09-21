using UnityEngine;
using System.Collections;
using Assets.Scripts.Weapon;
using System;
using Assets.Scripts.Characterrr;

public class Sword :MonoBehaviour, IWeapon
{
    [SerializeField]
    private float attackPower;
    public float AttackPower
    {
       get { return attackPower; }
    }
}
