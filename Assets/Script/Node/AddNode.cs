using GraphProcessor;
using System;
using UnityEngine;

[Serializable]
[NodeMenuItem("Custom/Add")]
public class AddNode : BaseNode
{
    [Input(name = "A")]
    public float _input1;

    [Input(name = "B")]
    public float _input2;

    [Output(name = "Out", allowMultiple = false)]
    public float _output;

    protected override void Process()
    {
        _output = _input1 + _input2;
    }
}
