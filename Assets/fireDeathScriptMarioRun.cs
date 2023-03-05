using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fireDeathScriptMarioRun : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void OnTriggerEnter2D(Collider2D collision)
	{
		print("A collision Occured");
		if(collision.gameObject.tag == "Player")
		{
			//Kill the player, they just got hit by the camera
			SceneManager.LoadScene("Level 1");
			//currently that means going back to level 1, in the future, that may mean somehting else.
		}	
	}
}
