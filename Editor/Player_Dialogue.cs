using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UIElements;

namespace DialogueSystem.Editor
{
    public class Player_Dialogue : DialogueGraphNode
    {
        public Player_Dialogue() : base("Player Dialogue Node")
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
                typeof(int)
            );
            generatedPort.portName = "NPC Dialogue";
            outputContainer.Add(generatedPort);
        }
        private void _setupPuertoSalida()
        {
            var generatedPort = this.InstantiatePort(
                Orientation.Horizontal,
                Direction.Output,
                Port.Capacity.Single,
                typeof(float)
            );
            generatedPort.portName = "NPC Dialogue";
            outputContainer.Add(generatedPort);
        }
    }
}