namespace Game.Thing
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Thing : MonoBehaviour
    {
        private Material material;

        private Color highLightColor = Color.red; 
        
        private Color defaultColor = Color.white;
        
        // Start is called before the first frame update
        void Start()
        {
            material = GetComponent<Renderer>().material;
            SetHighLightOff();
        }

        public void SetHighlightOn()
        {
            material.color = highLightColor;
        }

        public void SetHighLightOff()
        {
            material.color = defaultColor;
        }
    }
}


