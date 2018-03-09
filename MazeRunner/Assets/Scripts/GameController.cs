using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject groundSquarePrefab;
    GameObject[] walls;
    //public GameObject[][] groundSquares; 
	// Use this for initialization
	void Start () {
        walls = GameObject.FindGameObjectsWithTag("MoveWall");
        // groundSquares = new GameObject[10,10];
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
	}
}
