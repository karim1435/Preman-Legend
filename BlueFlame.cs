using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
public class BlueFlame : MonoBehaviour, IFlame
{
    public void ShowFlame()
    {
        GameObject blueFlame = Instantiate(Resources.Load("Flame-blue", typeof(GameObject))) as GameObject;
        blueFlame.transform.parent = transform;
    }
}
