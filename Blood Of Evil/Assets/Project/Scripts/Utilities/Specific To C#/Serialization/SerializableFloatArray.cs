﻿using UnityEngine;
using System.Collections;

namespace BloodOfEvil.Utilities.Serialization
{
    [System.Serializable]
    public class SerializableFloatArray
    {
        #region Fields
        public float[] floatArray;
        #endregion

        #region Constructor
        public SerializableFloatArray() { }

        public SerializableFloatArray(int length)
        {
            this.floatArray = new float[length];
        }
        #endregion

        #region Public Behaviour
        public SerializableFloatArray(float[] floatArray)
        {
            this.floatArray = floatArray;
        }
        #endregion
    }
}