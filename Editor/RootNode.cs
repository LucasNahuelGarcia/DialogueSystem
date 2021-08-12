using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor.Experimental.GraphView;

namespace DialogueSystem.Editor
{
    public class RootNode : DialogueGraphNode
    {
        public RootNode() : base("Root Node")
        {
            _setupPuertoSalida();
            Refresh();
        }

        private void _setupPuertoSalida()
        {
            var generatedPort = this.InstantiatePort(
                Orientation.Horizontal,
                Direction.Output,
                Port.Capacity.Single,
                typeof(float)
            );
            generatedPort.portName = "Out";
            outputContainer.Add(generatedPort);
        }
    }
}