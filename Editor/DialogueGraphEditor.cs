using UnityEditor.Experimental.GraphView;
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEngine;
using UnityEditor.Callbacks;
using UnityEditor.UIElements;

namespace DialogueSystem.Editor
{
    public class DialogueGraphEditor : EditorWindow
    {
        private DialogueGraphView _graphView;

        [MenuItem("Tools/Dialogue Graph")]
        public static void OpenDialogueGraphEditor()
        {
            var window = GetWindow<DialogueGraphEditor>();
            window.titleContent = new GUIContent("Dialogue Graph");
        }

        private void OnEnable()
        {
            ConstructGraph();
            GenerateToolbar();
        }
        private void OnDisable()
        {
            rootVisualElement.Remove(_graphView);
        }


        private void ConstructGraph()
        {
            _graphView = new DialogueGraphView
            {
                name = "Dialogue Graph"
            };
            _graphView.StretchToParentSize();
            rootVisualElement.Add(_graphView);
        }

        private void GenerateToolbar()
        {
            var toolbar = new Toolbar();
            CreateNodeButtons(toolbar);
            rootVisualElement.Add(toolbar);
        }

        private void CreateNodeButtons(Toolbar toolbar)
        {
            foreach (KeyValuePair<string, Func<Node>> item in NodeFactory.nodos)
            {
                Button boton = new Button(() => AddNode(item.Value.Invoke()));
                boton.text = item.Key;
                toolbar.Add(boton);
            }
        }

        private void AddNode(Node node)
        {
            _graphView.AddElement(node);
        }

        [OnOpenAssetAttribute(1)]
        public static bool OnOpenAsset(int instanceID, int line)
        {
            bool isOurType = EditorUtility.InstanceIDToObject(instanceID) is DialogueSystem.DialogueSystemScript;
            Debug.Log("Abriendo asset : " + isOurType);

            if(isOurType)
                OpenDialogueGraphEditor();
            return true;
        }
    }
}