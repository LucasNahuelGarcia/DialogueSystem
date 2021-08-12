using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UIElements;
using System;

namespace DialogueSystem.Editor
{
    public class DialogueGraphView : GraphView
    {
        public DialogueGraphView()
        {
            SetupZoom(ContentZoomer.DefaultMinScale, ContentZoomer.DefaultMaxScale);
            VisualElementExtensions.AddManipulator(this, new ContentDragger());
            VisualElementExtensions.AddManipulator(this, new SelectionDragger());
            VisualElementExtensions.AddManipulator(this, new RectangleSelector());

            AddElement(NodeFactory.createRootNode());
        }

        public override List<Port> GetCompatiblePorts(Port startPort, NodeAdapter node) {
            var compatiblePorts=  new List<Port>();
            ports.ForEach((port) => {
                if (startPort != port && startPort.node != port.node)
                    compatiblePorts.Add(port);
            }); 
        
            return compatiblePorts;
        }
    }
}