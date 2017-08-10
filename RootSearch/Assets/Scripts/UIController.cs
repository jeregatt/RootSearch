using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class UIController : MonoBehaviour {

	public void RootSearch (){
		
		//It loads the Game scene, the scene called Game.
		SceneManager.LoadScene ("Game");
	}
		
	public void Quit (){

		//It will quit the game and the game screen will be closed.
		Application.Quit();
	}

  
}
