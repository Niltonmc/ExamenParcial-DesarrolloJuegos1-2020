using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    
	public List<GameObject> enemies;
    private float elapsed;

	[Header("Position Variables")]
	public float minPosX;
	public float maxPosX;
	private float currentXPos;
	
    void Start(){

	}
        
    void Update(){
		elapsed += Time.deltaTime;
		if (elapsed >= 2f) {
			elapsed = 0;
			int index = Random.Range (0, enemies.Count);
			currentXPos = Random.Range (minPosX, maxPosX);
			Vector2 pos = new Vector2(currentXPos,transform.position.y);
			Instantiate (enemies [index], pos, Quaternion.identity);
		}
	}
}

