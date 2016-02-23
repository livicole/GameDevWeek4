using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	public GameObject door;
	public GameObject cameraDoor;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			Destroy (door);
			Destroy (cameraDoor);
		}
	
	}
}
