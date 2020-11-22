namespace Game.Player
{
    using Game.Thing;
    
    using System.Collections;
    using System.Collections.Generic;
    
    using UnityEngine;

    public class Player : MonoBehaviour
    {
        // Set through inspector this is the list of thing objects
        public List<Thing> things;

        private Thing closestThing;

        // Update is called once per frame
        void Update()
        {
            float distanceToClosest = Mathf.Infinity;
            foreach (Thing thing in things)
            {
                float distanceToObject = Vector3.Distance(this.transform.position, thing.transform.position);

                if (distanceToObject < distanceToClosest)
                {
                    if (closestThing)
                        closestThing.SetHighLightOff();
                    
                    thing.SetHighlightOn();
                    closestThing = thing;
                    distanceToClosest = distanceToObject;
                }
            }
            if (closestThing)
                Debug.DrawLine(this.transform.position, closestThing.transform.position);
        }
    }
}


