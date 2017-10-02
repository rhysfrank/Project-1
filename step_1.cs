using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step_1 : MonoBehaviour {
	public int bronzePlayer; 
	public int silverPlayer;
	public int miningSpeed; 
	public int bronzeSupply; 
	public int silverSupply; 
	public int timeToMine; 
	public int currentCube; 
	float xPosition; 
	float yPosition; 




	public GameObject bronzeSprite;
	Vector3 cubePosition; 
	public GameObject goldSprite; 
	public GameObject silverSprite; 


	// Use this for initialization
	void Start () {
		bronzePlayer = 0; 
		silverPlayer = 0; 
		miningSpeed = 4; 
		bronzeSupply = 3; 
		silverSupply = 2; 
		timeToMine = 1; 
		xPosition = 0; 
		yPosition = 0; 



	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > timeToMine) {
			// mine some gotdang ore, and update the number of ore the player has

			// only mine bronze if we have at least one in the supply
			if (bronzeSupply >= 1) {
				bronzeSupply -= 1; 
				bronzePlayer += 1;

				xPosition += Random.Range (-5, 5);
				yPosition += Random.Range (0, 4);
				cubePosition = new Vector3 (xPosition, yPosition, 0f);
				Instantiate (bronzeSprite, cubePosition, Quaternion.identity);

			}
			// only mine silver if there's no bronze in the supply AND we have at least one silver
			else if (bronzeSupply == 0 && silverSupply > 0) {
				silverSupply -= 1; 
				silverPlayer += 1; 

				xPosition += Random.Range (-5, 5);
				yPosition += Random.Range (0, 4);
				cubePosition = new Vector3 (Random.Range (-5, 5), Random.Range (0, 4), 0f); 
				Instantiate (silverSprite, cubePosition, Quaternion.identity);
			}

			// make sure we wait another miningSpeed seconds before mining again 

			// tell the player how much ore they have
			print ("Bronze: "+bronzePlayer); 
			print ("Silver: "+silverPlayer); 

			timeToMine += miningSpeed;

		
		}
	}
}