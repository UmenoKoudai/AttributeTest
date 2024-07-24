 using GraphProcessor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

[NodeCustomEditor(typeof(Float2Node))]
public class FloatNodeView : BaseNodeView
{
    public override void Enable()
    {
        var floatNode = nodeTarget as Float2Node;
        DoubleField floatField = new DoubleField { value = floatNode._input };

        floatNode.onProcessed += () => floatField.value = floatNode._input;

        floatField.RegisterValueChangedCallback((v) =>
        {
            owner.RegisterCompleteObjectUndo("Update floatNode input");
            floatNode._input = (float)v.newValue;
        });

        controlsContainer.Add(floatField);
    }
}
