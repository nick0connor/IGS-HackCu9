using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public int playerHealth = 10;
    public int goblinsKilled = 0;
    public int maxGobs = 3;

    private bool[] dead = new bool[] {false, false, false};
    public GameObject goblin1, goblin2, goblin3;

    public GameObject level, winScreen;

    void Awake(){
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            killGoblin();
        }
    }

    public void killGoblin()
    {
        goblinsKilled++;
        
        if(goblinsKilled >= maxGobs)
        {
            level.SetActive(false);
            winScreen.SetActive(true);
        }
    }
}
