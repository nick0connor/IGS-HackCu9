using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cameraFollw : MonoBehaviour
{
    // Start is called before the first frame update
	
	public GameObject player;
    void Start()
    {
        player = GameObject.Find("Character");
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = new Vector3(player.transform.position.x, player.transform.position.y+2, player.transform.position.z - 10);
    }
}
