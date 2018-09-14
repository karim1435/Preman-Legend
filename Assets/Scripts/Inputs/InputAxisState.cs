using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Inputs
{
    [Serializable]
    public class InputAxisState
    {
        public string axisName;
        public float offValue;
        public Condition condition;
        public Buttons button;

        public bool Value
        {
            get
            {
                float value = Input.GetAxis(axisName);
                switch (condition)
                {
                    case Condition.GreaterThan:
                        return value > offValue;
                    case Condition.LessThan:
                        return value < offValue;
                }
                return false;
            }
        }
    }
}
