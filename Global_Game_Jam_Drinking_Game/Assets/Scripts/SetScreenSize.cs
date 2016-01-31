using UnityEngine;
using System.Collections;

public class SetScreenSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.SetResolution(609,974,true);
		DontDestroyOnLoad (GameObject.Find("Canvas"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
