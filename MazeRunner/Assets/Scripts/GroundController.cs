using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour {
    public GameObject groundSquarePrefab;
    //public GameObject[][] groundSquares; 
	// Use this for initialization
	void Start () {
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
		
	}
}
