using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{

	public void gotocredits(){
		// Save game data

		// Close game
		Debug.Log ("CLICKING");
		SceneManager.LoadScene ("_Scenes/Credits");
	}
}

