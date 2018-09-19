using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;
public class RedFlame : MonoBehaviour, IFlame
{
    public void ShowFlame()
    {
        GameObject redFlame = Instantiate(Resources.Load("Flame-red", typeof(GameObject))) as GameObject;
        redFlame.transform.parent = transform;
    }
}
