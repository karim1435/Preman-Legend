using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Missile : MonoBehaviour, IWeapon
{
    public void Shoot()
    {
        Vector3 initialPosition = new Vector3(this.transform.position.x, this.transform.position.y + 1f, 0);
        GameObject missile = Instantiate(Resources.Load("Missile", typeof(GameObject))) as GameObject;
        missile.transform.position = initialPosition;
        missile.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 3f);
    }
}
