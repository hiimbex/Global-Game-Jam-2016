using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class randomforward : MonoBehaviour {

	public void randomGoForward(){
		Debug.Log ("random!");
		float rand= Mathf.Floor(Random.Range(1,4));
		string level = rand.ToString ();
		Debug.Log (level);
		SceneManager.LoadScene (level,LoadSceneMode.Single);
	}

	public void toBeerPong(){
		SceneManager.LoadScene ("BeerPong");
	}

	public void toKottabos(){
		SceneManager.LoadScene ("Kottabos");
	}

	public void toCredits(){
		SceneManager.LoadScene ("Credits");
	}
		

	public void toRussianRoulette(){
		SceneManager.LoadScene ("Russian Roulette");
	}
}
