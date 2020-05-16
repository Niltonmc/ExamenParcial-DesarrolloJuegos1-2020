using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour{

    [Header("Button Variables")]
    public Button btnRestart;

    // Start is called before the first frame update
    void Start(){
		btnRestart.onClick.AddListener (() => GoGame ());
	}

    void GoGame(){
        SceneManager.LoadScene("Menu");
	}
}
