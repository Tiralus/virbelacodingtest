namespace Game.HighLight
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class HighLight : MonoBehaviour
    {
        private Material material;

        public Color highLightColor = Color.white;
        
        public Color defaultColor = Color.white;
        
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


