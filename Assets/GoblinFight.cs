using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class GoblinFight : MonoBehaviour
{

    private bool goblinTurn, gameActive;
    public int goblinHealth, playerHealth;

    public GameObject goblin, player, menu;

    // Start is called before the first frame update
    void Start()
    {
        hideUI();
        gameActive = true;
        StartCoroutine(Test());
        goblinHealth = 5;
        playerHealth = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameActive)
        {
            if (goblinTurn)
            {
                
                switch (Mathf.Floor(Random.Range(0.0f, 2.0f)))
                {
                    case 0:
                        AttackPunch(false);
                        break;
                    case 1:
                        AttackInsult(false);
                        break;
                    case 2:
                        AttackCarBattery(false);
                        break;
                    default:
                        AttackPunch(false);
                        break;
                }
                goblinTurn = false;
                showUI();
            }
        }
	}

    private void updatePlayer(int healthChange)
    {
        playerHealth += healthChange;

        if(playerHealth <= 0 )
        {
            gameActive = false;
        }
    }

    private void updateGoblin(int healthChange)
    {
        goblinHealth += healthChange;

        if(goblinHealth <= 0 )
        {
            gameActive = false;
        }
    }

    public void AttackPunch(bool playerAttack)
    {
        hideUI();
        
        if(playerAttack)
        {
            updateGoblin(-1);
            StartCoroutine(Test());
            
        } else
        {
            updatePlayer(-1);
        }
    }

    public void AttackInsult(bool playerAttack)
    {
        hideUI();

        if (playerAttack)
        {
            updateGoblin(-2);
            StartCoroutine(Test());
        }
        else
        {
            updatePlayer(-2);
        }
    }

    public void AttackCarBattery(bool playerAttack)
    {
        hideUI();

        if (playerAttack)
        {
            updateGoblin(-5);
            StartCoroutine(Test());
        }
        else
        {
            updatePlayer(-5);
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

    IEnumerator Test()
    {
        yield return new WaitForSecondsRealtime(1);
        goblinTurn = true;
    }
}
