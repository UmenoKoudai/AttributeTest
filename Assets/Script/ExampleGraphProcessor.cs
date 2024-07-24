using GraphProcessor;
using System.Collections.Generic;
using System.Linq;
using Unity.Jobs;

public class ExampleGraphProcessor : BaseGraphProcessor
{
    private List<BaseNode> _processList;
    public float Result { get; private set; }

    public ExampleGraphProcessor(BaseGraph graph) : base(graph)
    {

    }

    public override void Run()
    {
        var count = _processList.Count;

        for(var i = 0; i < count; i++)
        {
            _processList[i].OnProcess();
        }
        JobHandle.ScheduleBatchedJobs();

        var resultNode = _processList.OfType<ResultNode>().FirstOrDefault();
        Result = resultNode.Result;
    }

    public override void UpdateComputeOrder()
    {
        _processList = graph.nodes.OrderBy(n => n.computeOrder).ToList();
    }
}
