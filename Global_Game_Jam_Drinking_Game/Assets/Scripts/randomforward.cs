using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class randomforward : MonoBehaviour {

	public void randomGoForward(){
		Debug.Log ("random!");
		float rand= Mathf.Floor(Random.Range(1,2));
		string level = rand.ToString ();
		Debug.Log (level);
		SceneManager.LoadScene (level);
	}

}
