using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(Time.time>1 && Time.time<50){
       this.transform.Translate(Vector3.right* Time.deltaTime);
		}
	   if(Time.time>13 && Time.time<20){
		   this.transform.Translate(Vector3.up* Time.deltaTime);
	   
		}
    }
}
