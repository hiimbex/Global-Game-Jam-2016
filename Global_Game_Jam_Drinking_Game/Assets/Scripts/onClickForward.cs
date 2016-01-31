using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class onClickForward : MonoBehaviour {

	public void nextScene(){
		// Save game data
	
		// Close game
		Debug.Log ("CLICKING");
		SceneManager.LoadScene ("_Scenes/USA");
	}
}