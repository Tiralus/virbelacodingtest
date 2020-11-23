namespace Game.Player
{
    using Game.HighLight;
    
    using System.Collections.Generic;
    
    using UnityEngine;

    public class Player : MonoBehaviour
    {
        // Set through inspector this is the list of game objects containing highlight
        public List<GameObject> gameObjects;

        private HighLight closestHighLight;
        
        // Update is called once per frame
        void Update()
        {
            float distanceToClosest = Mathf.Infinity;
            
            foreach (GameObject gameObject in gameObjects)
            {
                float distanceToObject = Vector3.Distance(this.transform.position, gameObject.transform.position);

                HighLight highLight = gameObject.GetComponent<HighLight>();

                if (distanceToObject < distanceToClosest && highLight)
                {
                    if (closestHighLight)
                        closestHighLight.SetHighLightOff();
                    
                    highLight.SetHighlightOn();
                    closestHighLight = highLight;
                    distanceToClosest = distanceToObject;
                }
            }
            
            if (closestHighLight)
                Debug.DrawLine(this.transform.position, closestHighLight.transform.position);
        }
    }
}


