using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
	public float start_time;
    // Start is called before the first frame update
    void Start()
    {
        start_time=Time.time;
    }

    // Update is called once per frame
    void Update()
    {
		if((Time.time-start_time)>1 && (Time.time-start_time)<50){
       this.transform.Translate(Vector3.right* Time.deltaTime);
		}
	   if((Time.time-start_time)>13 && (Time.time-start_time)<20){
		   this.transform.Translate(Vector3.up* Time.deltaTime);
	   
		}
    }
}
