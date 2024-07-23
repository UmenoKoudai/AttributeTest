using GraphProcessor;
using System;
using UnityEngine;

[Serializable]
[NodeMenuItem("Custom/result")]
public class ResultNode : BaseNode
{
    [Input(name = "Result")]
    public float _input;

    private float _result;
    public float Result => _result;

    public override string name => "Result";

    protected override void Process()
    {
        _result = _input;
    }
}
