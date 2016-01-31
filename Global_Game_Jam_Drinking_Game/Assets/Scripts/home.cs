using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{

	public void goHome(){
		// Save game data

		// Close game
		Debug.Log ("Going home!");
		SceneManager.LoadScene ("_Scenes/Start");
	}
}

