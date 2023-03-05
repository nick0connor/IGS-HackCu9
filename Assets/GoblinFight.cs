using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class GoblinFight : MonoBehaviour
{

    private bool goblinTurn;
    private int goblinHealth, playerHealth;

    public GameObject goblin, player, menu;

    // Start is called before the first frame update
    void Start()
    {
        goblinTurn = false;
        goblinHealth = 5;
        playerHealth = 10;
    }

    // Update is called once per frame
    void Update()
    {
		if(goblinTurn)
        {


        } else
        {


        }
		
	}

    public void showUI()
    {
        menu.SetActive(true);
    }

    public void hideUI()
    {
        menu.SetActive(false);
    }
}
