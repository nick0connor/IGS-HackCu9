using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoblinFight : MonoBehaviour
{

    private bool goblinTurn, gameActive;
    public int goblinHealth = 5;
    public int playerHealth;

    public GameObject stateSpace;
    public GameObject goblin, player, menu;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        hideUI();
        gameActive = true;
        StartCoroutine(Test(1));
        goblinHealth = 5;
        playerHealth = gm.playerHealth;
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
            //var speed = 1.0f; //how fast it shakes
            //var amount = 100.0f; //how much it shakes
            //Vector3 tr = goblin.transform.position;
            //tr.x = Mathf.Sin(Time.time * speed) * amount; ;
        } 
	}

    private void updatePlayer(int healthChange)
    {
        playerHealth += healthChange;

        if(playerHealth <= 0 )
        {
            gameActive = false;
            StartCoroutine(Test2(0.1f));
        }
    }

    private void updateGoblin(int healthChange)
    {
        goblinHealth += healthChange;

        if(goblinHealth <= 0 )
        {
            gameActive = false;
            StartCoroutine(Test2(0.1f));
        }
    }

    public void AttackPunch(bool playerAttack)
    {
        hideUI();
        
        if(playerAttack)
        {
            updateGoblin(-1);
            //shakeGoblin();
            StartCoroutine(Test(1));
            
        } else
        {
            updatePlayer(-1);
            //shakePlayer();
        }
    }

    public void AttackInsult(bool playerAttack)
    {
        hideUI();

        if (playerAttack)
        {
            updateGoblin(-2);
            //shakeGoblin();
            StartCoroutine(Test(1));
        }
        else
        {
            updatePlayer(-2);
            //shakePlayer();
        }
    }

    public void AttackCarBattery(bool playerAttack)
    {
        hideUI();

        if (playerAttack)
        {
            updateGoblin(-5);
            //shakeGoblin();
            StartCoroutine(Test(1));
        }
        else
        {
            updatePlayer(-5);
            //shakePlayer();
        }
    }

    private void shakePlayer()
    {
    //    var speed = 1.0f; //how fast it shakes
    //    var amount = 100.0f; //how much it shakes
    //    Vector3 tr = player.transform.position;
    //    tr.x = Mathf.Sin(Time.time * speed) * amount;
        //Vector3 initPos = player.transform.position;

        //player.transform.Translate(Vector3.left * Time.deltaTime);
        //StartCoroutine(Test(0.1f));
        //player.transform.Translate(Vector3.right * Time.deltaTime * 2);
        //StartCoroutine(Test(0.1f));
        //player.transform.Translate(Vector3.left * Time.deltaTime);

        //player.transform.position = initPos;
    }

    private void shakeGoblin()
    {
        //var speed = 1.0f; //how fast it shakes
        //var amount = 100.0f; //how much it shakes
        //Vector3 tr = goblin.transform.position;
        //tr.x = 5;
        //    //Mathf.Sin(Time.time * speed) * amount;
    }

    public void showUI()
    {
        menu.SetActive(true);
    }

    public void hideUI()
    {
        menu.SetActive(false);
    }

    IEnumerator Test(float seconds)
    {
        yield return new WaitForSecondsRealtime(1);
        goblinTurn = true;
    }

    IEnumerator Test2(float seconds)
    {
        yield return new WaitForSecondsRealtime(3);
        stateSpace.SetActive(false);
        gm.EndGoblinFight();
    }
}
