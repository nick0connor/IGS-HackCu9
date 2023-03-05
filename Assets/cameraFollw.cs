using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;


public class cameraFollw : MonoBehaviour
{
    // Start is called before the first frame update
	
	public GameObject player;
    void Start()
    {
		 Scene currentScene = SceneManager.GetActiveScene ();
 
         // Retrieve the name of t$$anonymous$$s scene.
         string sceneName = currentScene.name;
		if(sceneName == "TEST"){
        player = GameObject.Find("th");
		}
		else if(sceneName == "Level 1"){
			player = GameObject.Find("Character");
		}
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = new Vector3(player.transform.position.x, player.transform.position.y+2, player.transform.position.z - 10);
    }
}
