using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    public List<GameObject> prefabs;
    public int roundcount = 5;
    public float TimeBetweenRounds;
    public int Spawnarea=5;
    [Header("Debug")]
    public float currentTime = 0f;
    public int CurrentRound = 0;

    public void Spawner()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= TimeBetweenRounds)
        {
            ObjectGeneration();
            currentTime = 0;
            CurrentRound++;
            if (CurrentRound>= roundcount)
            {
                //reincia rondas
                CurrentRound = 0;
                //ajustamos frecu
                TimeBetweenRounds *= 0.9f;
                
            }
        }
    }
    public void ObjectGeneration()
    {
        Vector3 SpawnPostition = new Vector3(Random.Range(-Spawnarea,Spawnarea), Random.Range(-Spawnarea,Spawnarea),0);
        GameObject obj = prefabs[Random.Range(0, prefabs.Count)];
        GameObject clone = Instantiate(obj,SpawnPostition,Quaternion.identity);
        clone.transform.parent = transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawner();
        
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawCube(transform.position, new Vector3(-Spawnarea, -Spawnarea, 0));
    }
}
