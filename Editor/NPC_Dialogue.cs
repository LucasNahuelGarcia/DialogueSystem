using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UIElements;

namespace DialogueSystem.Editor
{
    public class NPC_Dialogue : DialogueGraphNode
    {
        public NPC_Dialogue() : base("NPC Dialogue Node")
        {
            _setupTextInput();
            _setupPuertoSalida();
            _setupPuertoEntrada();
            Refresh();
        }
        private void _setupTextInput()
        {
            TextField textField = new TextField(200, true, false, 'a');
            this.mainContainer.Add(textField);
        }
        private void _setupPuertoEntrada()
        {
            var generatedPort = this.InstantiatePort(
                Orientation.Horizontal,
                Direction.Input,
                Port.Capacity.Multi,
                typeof(float)
            );
            generatedPort.portName = "In";
            outputContainer.Add(generatedPort);
        }
        private void _setupPuertoSalida()
        {
            var generatedPort = this.InstantiatePort(
                Orientation.Horizontal,
                Direction.Output,
                Port.Capacity.Multi,
                typeof(int)
            );
            generatedPort.portName = "Options";
            outputContainer.Add(generatedPort);
        }
    }
}