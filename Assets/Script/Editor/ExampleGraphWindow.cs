using GraphProcessor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions;

public class ExampleGraphWindow : BaseGraphWindow
{
    protected override void InitializeWindow(BaseGraph graph)
    {
        Assert.IsNotNull(graph);

        //�E�B���h�E�̃^�C�g����K���ɐݒ�
        var filName = Path.GetFileNameWithoutExtension(AssetDatabase.GetAssetPath(graph));
        titleContent = new GUIContent(ObjectNames.NicifyVariableName(filName));

        //�O���t��ҏW���邽�߂̃r���[�ł���GraphView��ݒ�
        if(graphView == null)
        {
            graphView = new BaseGraphView(this);
        }
        rootView.Add(graphView);
    }

    //public override IEnumerable<KeyValuePair<string, Type>> FilterCreateNodeMenuEntries()
    //{
    //    foreach(var nodeMenuItem in NodeProvider.GetNodeMenuEntries())
    //    {
    //        if(nodeMenuItem.type == typeof(ResultNode))
    //        {
    //            continue;
    //        }

    //        var a = new KeyValuePair<string, Type>("", new ());
    //        var b = nodeMenuItem;
    //        yield return nodeMenuItem;
    //    }
    //}
}
