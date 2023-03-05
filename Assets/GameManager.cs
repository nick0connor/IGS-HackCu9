using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public int playerHealth = 10;
    public int goblinsKilled = 0;
    public int maxGobs = 3;

    public GameObject currentGoblin;

    private bool[] dead = new bool[] {false, false, false};
    public GameObject goblin1, goblin2, goblin3;
    public GameObject[] goblins;

    public GameObject level, winScreen;

    void Awake(){
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        goblins = new GameObject[] { goblin1, goblin2, goblin3 };
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void LoadGobFight(GameObject goblin)
    {
        currentGoblin = goblin;
        SceneManager.LoadScene("fightScene");
    }

    public void EndGoblinFight()
    {
        if(currentGoblin != null) {
            
            Destroy(currentGoblin);
        }
        SceneManager.LoadScene("Level 1");
    }

    public void killGoblin()
    {
        
    }
}
