using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class BoxesScript : MonoBehaviour
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
        //print("We hit smth");
        if(collision.tag == "Player")
        {
            Transform pt = GameObject.FindGameObjectWithTag("Player").transform;
            //print(pt.position.y);
            //If this is the player, they may have either hit the elevator or exit
            if (pt.position.x <= -6)
            {
                print("We hit the exit");
         
            }
            else if(pt.position.y > 3.5)
            {
                print("We hit the elevator");
            }
            else if(pt.position.x > 4.5)
            {
                EditorSceneManager.LoadScene("Platform_minigame");
            }
        }
    }
}
