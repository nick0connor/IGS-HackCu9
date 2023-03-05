using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class BoxesScript : MonoBehaviour
{
    public GameManager gm;
    public GameObject winScreen, Lvl;
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
                print(gm.doorOpen);
                //if (gm.doorOpen)
                //{
                    //winScreen.SetActive(true);
                    //Lvl.SetActive(false);
                    EditorSceneManager.LoadScene("Weiner");
                //}
         
            }
            else if(pt.position.y > 3.5)
            {
                print("We hit the elevator");
            }
            else if(pt.position.x > 2)
            {
                EditorSceneManager.LoadScene("Platform_minigame");
            }
        }
    }
}
