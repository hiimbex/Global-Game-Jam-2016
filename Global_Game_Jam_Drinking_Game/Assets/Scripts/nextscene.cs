using UnityEngine;
using System.Collections;

public class nextscene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Forward")) {
			Debug.Log ("button pressed");
			Application.LoadLevel ("USA");

		}
	}
}
