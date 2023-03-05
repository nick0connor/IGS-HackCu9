using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarleyMover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public SpriteRenderer spriteRenderer;
    public Animator ani;
    bool moving;

    //private bool stuck;

    // Start is called before the first frame update
    void Start()
    {
        //stuck = false;
        spriteRenderer.flipX = false;
        moving = false;
    }

    // Update is called once per frame
    void Update()
    {
        moving = false;
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
            this.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            moving = true;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
            moving = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            spriteRenderer.flipX = true;
            this.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            moving = true;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            spriteRenderer.flipX = false;
            this.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            moving = true;
        }
        ani.SetBool("Moving", moving);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Blockade")
        {
            //Debug.Log("fadsl;kf");
            
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name == "Blockade")
        {
            //Debug.Log("fadsl;kf");
        }
    }
}
