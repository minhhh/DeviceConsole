using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;

namespace DeviceConsole
{
    public class DebugCommandAttribute : Attribute
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string ArgsDescription { get; private set; }

        public DebugCommandAttribute (string name, string description = "", string argsDescription = "")
        {
            Name = name.ToLower ();
            Description = description;
            ArgsDescription = argsDescription;
        }
    }
}
