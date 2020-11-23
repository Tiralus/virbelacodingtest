namespace Game.Player
{
    using Game.HighLight;
    using Game.SpawnObject;
    
    using System.Collections.Generic;
    
    using UnityEngine;
    
    public class Player : MonoBehaviour
    {
        // Set through inspector this is the list of game objects containing highlight
        public List<GameObject> gameObjects;

        public SpawnObject spawner;

        private HighLight closestHighLight;

        // Added the spawner class with an action to return the spawned object.
        public void Start()
        {
            if (spawner)
            {
                spawner.OnSpawn += OnSpawn;
            }
        }

        // Make sure we remove ourselves from the action, prevent memory leaks
        public void OnDestroy()
        {
            if (spawner)
            {
                spawner.OnSpawn -= OnSpawn;
            }
        }

        // Update is called once per frame
        public void Update()
        {
            SetClosestObject();
        }

        public void OnSpawn(GameObject newSpawn)
        {
            gameObjects.Add(newSpawn);
        }

        // This is a fairly straightfoward implementation to find the nearest gameobject
        // Go through the list of objects and distance check each one. 
        public void SetClosestObject()
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


