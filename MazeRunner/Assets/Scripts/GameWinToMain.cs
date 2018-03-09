using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWinToMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(Wait());
    }
    void FixedUpdate()
    {
        
    }
    IEnumerator Wait()
    {

        yield return new WaitForSeconds(10);
        SceneManager.UnloadSceneAsync("GameWin");
        SceneManager.LoadScene("Start");
    }
}
