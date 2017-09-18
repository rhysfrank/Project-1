using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step_1 : MonoBehaviour {


	float time; 
	//float uses a decimal for the time
	int myScore; 
	//int means only normal numbers 
	bool printedMessage;
	//bool has to be true or false

	// Use this for initialization 
	void Start () {
			print (“The game has begun!”);

			printedMessage = false; 
		}

		// Update is called once per frame
		void Update () { 
			if (Time.time  > 3 && printedMessage == false) {
			print (“It has been three seconds!”); 
				printedMessage = true;
		}
	}
}
		
	



