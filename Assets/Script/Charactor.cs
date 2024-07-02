using UnityEngine;

public class Charactor : MonoBehaviour
{
    [SerializeField, Range(0, 10)]
    int _value;
    [SerializeField, Popup("1", "2", "3", "4")]
    string _value2;
    [SerializeField, Popup(1, 2, 3)]
    int _value3;

    private void Update()
    {
        Debug.Log($"String{_value2}");
        Debug.Log($"Int{_value3}");
    }
}
