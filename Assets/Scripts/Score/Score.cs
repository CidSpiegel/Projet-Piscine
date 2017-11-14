using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : Singleton<Score> {

    // Use this for initialization

    public int value = 10;

    public void ChangeVal(int val){
        value = val;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
