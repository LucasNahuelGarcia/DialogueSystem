using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DialogueSystem
{
    public class DialogueChar : MonoBehaviour, Accionable
    {
        [SerializeField] private Camera mainCamera;
        [SerializeField] private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
        }
        private void awake()
        {
            mainCamera = mainCamera ?? Camera.main;
        }
        public void Accionar(GameObject caller)
        {

        }
    }
}