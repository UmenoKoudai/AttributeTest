using GraphProcessor;
using UnityEditor.Callbacks;
using UnityEngine;
using System.Linq;

#if UNITY_EDITOR
using UnityEditor;
#endif

//CreateメニューからScriptableObjectのアセットを作れるように
[CreateAssetMenu(menuName = "Example Graph")]
public class ExampleGraph : BaseGraph
{
    protected override void OnEnable()
    {
        base.OnEnable();
        if(!nodes.Any(x => x is ResultNode))
        {
            AddNode(BaseNode.CreateFromType<ResultNode>(Vector2.zero));
        }
    }

#if UNITY_EDITOR
    //ダブルクリックでウィンドウが開かれるように
    [OnOpenAsset(0)]
    public static bool OnBaseGraphOpended(int instanceID, int line)
    {
        var asset = EditorUtility.InstanceIDToObject(instanceID) as ExampleGraph;
        if(asset is null) return false;
        var window = EditorWindow.GetWindow<ExampleGraphWindow>();
        window.InitializeGraph(asset);
        return true;
    }
#endif
}
