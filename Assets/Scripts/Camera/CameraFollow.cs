using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Scripts.Characterrr;
namespace Assets.Scripts.Camera
{
    public class CameraFollow:MonoBehaviour
    {
        [SerializeField]
        private float xMax;

        [SerializeField]
        private float xMin;

        [SerializeField]
        private float yMax;

        [SerializeField]
        private float yMin;

        private Transform target;

        void Start()
        {
            target = GameObject.Find("Player").transform;
        }
        void LateUpdate()
        {
            transform.position = new Vector3(
                Mathf.Clamp(target.position.x, xMin, xMax),
                Mathf.Clamp(target.position.y, yMin, xMax),
                transform.position.z);

        }
    }
}
