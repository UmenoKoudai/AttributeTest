using System;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(PopupAttribute))]
public class PopupDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        PopupAttribute popup = (PopupAttribute)attribute;
        EditorGUI.BeginChangeCheck();
        var objects = new string[popup._value.Length];
        for (int i = 0; i < popup._value.Length; i++)
        {
            objects[i] = Convert.ToString(popup._value[i]);
        }
        if (property.propertyType == SerializedPropertyType.Integer)
        {
            var currentValue = property.intValue;
            var currentindex = Array.IndexOf(popup._value, currentValue);
            var index = 0 < currentindex ? currentindex : 0;
            var selected = EditorGUILayout.Popup(label, index, objects);
            if (EditorGUI.EndChangeCheck())
            {
                property.intValue = (int)popup._value[selected];
            }
        }
        else if (property.propertyType == SerializedPropertyType.Float)
        {
            var currentValue = property.floatValue;
            var currentindex = Array.IndexOf(popup._value, currentValue);
            var index = 0 < currentindex ? currentindex : 0;
            var selected = EditorGUILayout.Popup(label, index, objects);
            if (EditorGUI.EndChangeCheck())
            {
                property.floatValue = (float)popup._value[selected];
            }
        }
        else if (property.propertyType == SerializedPropertyType.String)
        {
            var currentValue = property.stringValue;
            var currentindex = Array.IndexOf(popup._value, currentValue);
            var index = 0 < currentindex ? currentindex : 0;
            var selected = EditorGUILayout.Popup(label, index, objects);
            if (EditorGUI.EndChangeCheck())
            {
                property.stringValue = popup._value[selected].ToString();
            }
        }
        else
        {

        }
    }
}
