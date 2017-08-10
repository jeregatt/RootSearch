using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class UIController : MonoBehaviour {

	public void RootSearch (){
		
		//It loads the Game scene, the scene called Day
		SceneManager.LoadScene ("Game");
	}
		
	public void Quit (){

		//It loads the Game scene, the scene called  Quit
		Application.Quit();
	}

  
}
