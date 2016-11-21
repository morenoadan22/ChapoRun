using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour {

	public Button playButton;
	public Button creditsButton;
	public Button exit;

	// Use this for initialization
	void Start () {
		playButton = playButton.GetComponent<Button>();
		creditsButton = creditsButton.GetComponent<Button>();
		exit = exit.GetComponent<Button>();
	}
	
	public void OnExitClicked(){
		Application.Quit();		
	}

	public void OnPlayClicked(){
		SceneManager.LoadScene(1); 		
	}

	public void OnCreditsClicked(){
		SceneManager.LoadScene(2); 
	}

	public void Return(){
		SceneManager.LoadScene(0);
	}
}
