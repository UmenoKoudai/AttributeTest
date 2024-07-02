using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(SceneNameAttribute))]
public class SceneNameDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        SceneNameAttribute scene = (SceneNameAttribute)attribute;
        if (property.propertyType == SerializedPropertyType.String)
        {
            var currentName = property.stringValue;
            var currentIndex = System.Array.IndexOf(scene.Name, currentName);
            int index = 0 < currentIndex ? currentIndex : 0;
            EditorGUI.BeginChangeCheck();
            var selected = EditorGUILayout.Popup(label, index, scene.Name);
            if (EditorGUI.EndChangeCheck())
            {
                property.stringValue = scene.Name[selected];
            }
        }
    }
}
