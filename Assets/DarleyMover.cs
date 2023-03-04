using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarleyMover : MonoBehaviour
{
    public float moveSpeed = 5f;
    //private bool stuck;

    // Start is called before the first frame update
    void Start()
    {
        //stuck = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
            this.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Blockade")
        {
            //Debug.Log("fadsl;kf");
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
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
