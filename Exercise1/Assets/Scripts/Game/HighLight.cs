namespace Game.HighLight
{
    using UnityEngine;

    public class HighLight : MonoBehaviour
    {
        protected Renderer rend;

        public Color highLightColor = Color.white;
        
        public Color defaultColor = Color.white;
        
        void Awake()
        {
            rend = GetComponent<Renderer>();
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


