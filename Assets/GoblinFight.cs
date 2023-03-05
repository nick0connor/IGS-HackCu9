using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinFight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
		
    }

    // Update is called once per frame
    void Update()
    {
		 bool goblinAttack=true;
		bool fight=true;
		int goblinHealth=1;
		int playerHealth=10;
		while(fight==true){
		if(goblinHealth <=0 || playerHealth<=0){
			fight=false;
		}
		if (Input.GetKey(KeyCode.E)) {
			goblinAttack=true;
		}
        if(goblinAttack==true){
			this.transform.Translate(Vector3.up* Time.deltaTime);
			this.transform.Translate(Vector3.left*3* Time.deltaTime);
			playerHealth--;
			float j=Time.time;
			for(float i=Time.time; j==(i+2);i++){	
			}
			this.transform.Translate(Vector3.right*3* Time.deltaTime);
			goblinAttack=false;
		}
		
		
		}
}
}
