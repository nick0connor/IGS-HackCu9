using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagCollider : MonoBehaviour
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
        print("Col detected");
        if(collision.tag == "Player")
        {
            print(SceneManager.GetActiveScene().name);
            if(SceneManager.GetActiveScene().name == "Platform_minigame")
            {
                print("goto next");
                SceneManager.LoadScene("MarioRun");
            }
            else if(SceneManager.GetActiveScene().name == "MarioRun")
            {
                SceneManager.LoadScene("Level 1");
            }
        }
    }
}
