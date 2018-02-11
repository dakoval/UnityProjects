using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    private Rigidbody rb;
	private int count;

	public Text countText;
    public float speed;
	public Text winText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
		winText.text = "";
    }
    void FixedUpdate()
    {
        float moveHorizonal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizonal, 0.0f, moveVertical);
        rb.AddForce(movement*speed);
    }
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count++;
			SetCountText();
		}
	}
	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 8) {
			winText.text = "You Win";
		}
	}
}
