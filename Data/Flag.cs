using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VNCreator
{
    public class Flag
    {
        public string flagName;
        public bool flagValue;

        public Flag(string flagName, bool flagValue)
        {
            this.flagName = flagName;
            this.flagValue = flagValue;
        }
    }
}
