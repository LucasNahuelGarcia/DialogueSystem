using UnityEditor.Experimental.GraphView;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DialogueSystem.Editor
{
    public class NodeFactory
    {
        public static Dictionary<string, Func<Node>> nodos = new Dictionary<string, Func<Node>>() {
            {"Create Root", () => createRootNode()},
            {"Create Action", () => createActionNode()},
            {"Create NPC Dialogue", ()=> createNPCDialogueNode()} ,
            {"Create Player Dialogue", ()=> createPlayerDialogueNode()}
        };
        public static Node createRootNode()
        {
            return new RootNode();
        }
        public static Node createNPCDialogueNode()
        {
            return new NPC_Dialogue();
        }
        public static Node createActionNode()
        {
            return null;
        }
        public static Node createPlayerDialogueNode()
        {
            return new Player_Dialogue();
        }
    }
}