namespace Game
{
    using UnityEngine;

    public class HighLight : MonoBehaviour
    {
        protected Renderer rend;

        public Color highLightColor = Color.white;

        private Color defaultColor;
        
        void Awake()
        {
            rend = GetComponent<Renderer>();
            
            // Default color is the materials original color
            defaultColor = rend.material.color;
            
            SetHighLightOff();
        }

        public void SetHighlightOn()
        {
            rend.material.color = highLightColor;
        }

        public void SetHighLightOff()
        {
            rend.material.color = defaultColor;
        } 
    }
}


