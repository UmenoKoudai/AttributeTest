using GraphProcessor;
using UnityEngine.UIElements;

[NodeCustomEditor(typeof(ResultNode))]
public class ResultNodeView : BaseNodeView
{
    public override void Enable()
    {
        var resultNode = nodeTarget as ResultNode;
        var field = new DoubleField { value = resultNode.Result };

        resultNode.onProcessed += () => field.value = resultNode.Result;
        field.RegisterValueChangedCallback((v) =>
        {
            owner.RegisterCompleteObjectUndo("");
            //resultNode.Result = (float)v.newValue;
        });

        controlsContainer.Add(field);
    }
}
