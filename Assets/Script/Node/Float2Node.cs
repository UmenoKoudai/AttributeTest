using GraphProcessor;
using System;
using UnityEngine;

[Serializable, NodeMenuItem("Primitives/Float2")]
public class Float2Node : BaseNode
{
    [Output("Out")]
    public float _output;
    [Input("In")]
    public float _input;

    public override string name => "Float";

    protected override void Process() => _output = _input;
}
