using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class PopupAttribute : PropertyAttribute
{
    public readonly object[] _value;

    public PopupAttribute(params object[] value)
    {
        _value = value;
    }
}
