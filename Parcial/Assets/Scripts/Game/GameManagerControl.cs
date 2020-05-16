using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerControl : MonoBehaviour{

    [Header("Score Variables")]
    public Text txtScore;
    public int currentScore;

    [Header("Lives Variables")]
    public Text txtLives;
    public int currentLives = 3;

    // Start is called before the first frame update
    void Start() {
        InitialValues();
    }

    // Update is called once per frame
    void Update(){
        
    }

    void InitialValues(){
        UpdateScore(0);
        UpdateLives(0);
    }

    public void UpdateScore(int val){
        currentScore = currentScore + val;
        txtScore.text = "SCORE: " + currentScore.ToString();
    }

     public void UpdateLives(int val){
        currentLives = currentLives - val;
        txtLives.text = "LIVES: " + currentLives.ToString();
        if(currentLives <= 0){
           GameOver(); 
        }
    }

    void GameOver(){
         SceneManager.LoadScene("GameOver");
    }
}
