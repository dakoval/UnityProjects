using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody rb;
	private int count;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
		count = 0;
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
		}
	}

}
