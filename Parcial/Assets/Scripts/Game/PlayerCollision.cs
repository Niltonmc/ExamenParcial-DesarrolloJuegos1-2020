using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
	
    [Header("Score Variables")]
    public int scoreToAdd = 10;

    [Header("Damage Variables")]
    public int damageToApplicate = 1;

    [Header("Manager Variables")]
	private GameManagerControl gmManager;

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag != gameObject.tag){
            Destroy(other.gameObject);
            gmManager.UpdateScore(scoreToAdd);
        }else{
            Destroy(other.gameObject);
            gmManager.UpdateLives(damageToApplicate);   
        }
    }

    public void SetGameManager(GameManagerControl tmp){
        gmManager = tmp;
    }
}
