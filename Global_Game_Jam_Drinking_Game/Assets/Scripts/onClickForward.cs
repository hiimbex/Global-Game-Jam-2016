using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class onClickForward : MonoBehaviour {

	public void gotoUSA(){
		// Save game data
	
		// Close game
		Debug.Log ("CLICKING");
		SceneManager.LoadScene ("USA");
	}


}