using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    
	public Vector3 positionToCreate;

	[SerializeField]
    private GameObject uno;
	[SerializeField]
    private GameObject dos;
	[SerializeField]
    private GameObject tres;
	[SerializeField]
    private GameObject cuarto;
	[SerializeField]
    private GameObject quinto;

    [Header("Manager Variables")]
	public GameManagerControl gmManager;

    void Start(){
		string monster = PlayerPrefs.GetString ("player");

		//PlayerPrefs.SetString ("player","1");

		GameObject monsterGO = uno;

		if (monster == "1") {
			//print ("entra");
			monsterGO = uno;
		}
		if (monster == "2") {
			monsterGO = dos;
		}
		if (monster == "3") { 
			monsterGO = tres;
		}
		if (monster == "4") {
			monsterGO = cuarto;
		}
		if (monster == "5") {
			monsterGO = quinto;
		}

		GameObject tmp;
		tmp = Instantiate (monsterGO, positionToCreate, Quaternion.identity);
		tmp.GetComponent<PlayerCollision>().SetGameManager(gmManager);
	}
}
