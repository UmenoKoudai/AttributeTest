using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

[System.AttributeUsage(System.AttributeTargets.Field, Inherited = true, AllowMultiple = false)]

public class Range2Attribute : PropertyAttribute
{
    public readonly int _min;
    public readonly int _max;

    public Range2Attribute(int min, int max)
    {
        _min = min;
        _max = max;
    }
}
