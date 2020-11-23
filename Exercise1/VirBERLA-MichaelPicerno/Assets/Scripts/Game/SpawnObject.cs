namespace Game
{
    using System;
    using UnityEngine;
    using Random = UnityEngine.Random;

    public class SpawnObject : MonoBehaviour
    {
        public Vector3 spawnArea = new Vector3(8, 8, 0);

        // Object to spawn around
        public GameObject centralObject;

        public GameObject spawnThing;

        public GameObject spawnBot;

        public Action<GameObject> OnSpawn;

        // Update is called once per frame
        void Update()
        {
            // Space spawn a random thing or bot
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnRandom();
            }

            // B spawn a bot
            if (Input.GetKeyDown(KeyCode.B))
            {
                SpawnBot();
            }

            // T spawn a thing
            if (Input.GetKeyDown(KeyCode.T))
            {
                SpawnThing();
            }
        }

        public void SpawnThing()
        {
            Spawn(spawnThing);
        }
        
        public void SpawnBot()
        {
            Spawn(spawnBot);
        }

        public void Spawn(GameObject prefab)
        {
            if (prefab)
            {
                Vector3 spawnPosition = centralObject.transform.position + new Vector3(Random.Range(-spawnArea.x, spawnArea.x),
                    Random.Range(-spawnArea.y, spawnArea.y),
                    Random.Range(-spawnArea.z, spawnArea.z));

                GameObject newSpawn = Instantiate(prefab, spawnPosition, Quaternion.identity);
                if (OnSpawn != null)
                {
                    OnSpawn(newSpawn);
                }
            }
        }

        public void SpawnRandom()
        {
            int randomSpawn = Random.Range(0, 2);

            Spawn(randomSpawn == 0 ? spawnThing : spawnBot);
        }
    }
}
