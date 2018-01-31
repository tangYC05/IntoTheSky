using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ReloadScene : MonoBehaviour {

	public Button NextTarget;
	public Button QuitGame;

	// Use this for initialization
	void Start () 
	{
		NextTarget = NextTarget.GetComponent<Button> ();
		QuitGame = QuitGame.GetComponent<Button> ();
	}
	
	public void StartGame()
	{
		SceneManager.LoadScene ("Test Play");
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}
