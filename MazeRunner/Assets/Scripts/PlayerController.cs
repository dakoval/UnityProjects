using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    private int health = 3;
    public Text healthText;
    public Text lose;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        healthText.text = "Health "+health;
        lose.enabled= false;
    }
	
	// Update is called once per frame
	void Update () {
        float moveHorizonal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizonal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            SceneManager.UnloadSceneAsync("Game");
            SceneManager.LoadScene("GameWin");
        }
        if (other.gameObject.CompareTag("Rock"))
        {
           --health;
            healthText.text = "Health "+health;
            if (health <= 0)
            {
                lose.enabled = true;
                StartCoroutine(Wait());
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        SceneManager.UnloadSceneAsync("Game");
        SceneManager.LoadScene("Start");
    }

}
