using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;

namespace DialogueSystem.Editor
{
    public abstract class DialogueGraphNode : Node
    {
        public string GUID;
        public string DialogueText;
        public bool EntryPoint = false;

        public DialogueGraphNode(string name) : base() {
            this.title = name;
            this.DialogueText = name;
            this.GUID = Guid.NewGuid().ToString();
            this.SetPosition(new Rect(100, 200, 100, 150));
        }


        public void Refresh()
        {
            this.RefreshExpandedState();
            this.RefreshPorts();
        }
    }
}