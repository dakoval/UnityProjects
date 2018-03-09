using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public GameObject groundSquarePrefab;
    public GameObject rockPrefab;
    GameObject[] walls;
    private float rateOfSpawn = 1;
    private float nextSpawn = 0;
    //public GameObject[][] groundSquares; 
	// Use this for initialization
	void Start () {
        walls = GameObject.FindGameObjectsWithTag("MoveWall");
        
        for (float i = -45f; i <= 45f; i+=10)
        {
            for (float j = -45f; j <= 45f; j+=10)
            {
                Instantiate(groundSquarePrefab, new Vector3(i, .001f, j), Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject wall in walls)
        {
            wall.transform.Rotate(0, .5f, 0, Space.Self);
        }
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + rateOfSpawn;
            Vector3 spawnPos= new Vector3(Random.Range(-50f, 50f), 45f, Random.Range(-50f, 50f));
            GameObject obj = Instantiate(rockPrefab, spawnPos, Quaternion.identity);
            Destroy(obj, 5f);
        }
    }
}
