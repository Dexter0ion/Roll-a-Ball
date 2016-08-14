using UnityEngine;
using System.Collections;

public class CameraConroller : MonoBehaviour {

	public GameObject Player;

	private Vector3 diff;

	// Use this for initialization
	void Start () {
		diff = transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = Player.transform.position+diff;
	}
}
