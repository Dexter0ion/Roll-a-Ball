using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

	public float strength;
    
	private Rigidbody rb;

	private int count;

	public Text CountText;
	public Text WinText;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		TextUpdate ();
		WinText.text = "";
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * strength);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Stones"))
			{
			other.gameObject.SetActive(false);
			count += 1;
			TextUpdate ();
			}
	}

	void TextUpdate()
	{
		CountText.text = "Count: " + count.ToString ();

		if (count >= 18) 
		{
			WinText.text = "You Win";
		}
	}
}
