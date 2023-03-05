using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class AI : MonoBehaviour
{
    public bool hasTarget;
    public GameObject target;
    public float speed = 7f;
    public float waitTime = 10f;
    private float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        hasTarget = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(hasTarget)
        {
            // Go towards the target
            this.transform.Translate((target.transform.position - this.transform.position).normalized * speed * Time.deltaTime);

        } else
        {
            // Just kinda wander around. Be a silly little guy
            
            switch (Mathf.Floor(Random.Range(0.0f, 4.0f))) {
                case 0:
                    this.transform.Translate(((Vector3.up * speed) - this.transform.position).normalized * speed * Time.deltaTime);
                    break;
                case 1:
                    this.transform.Translate(((Vector3.down * speed) - this.transform.position).normalized * speed * Time.deltaTime);
                    break;
                case 2:
                    this.transform.Translate(((Vector3.left * speed) - this.transform.position).normalized * speed * Time.deltaTime);
                    break;
                case 3:
                    this.transform.Translate(((Vector3.right * speed) - this.transform.position).normalized * speed * Time.deltaTime);
                    break;
                default:
                    //this.transform.Rotate(Vector3.up * speed * Time.deltaTime);
                    break;
            }

        }
    }

    // On touching the box itself
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Blockade")
        {
            // Find a new path
        }

        // If the enemy collides with the character
        if (col.gameObject.name == "Character")
        {
            hasTarget = false;
        }
    }

    // On not touching the box itself
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name == "Character")
        {
            hasTarget = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {   
        // If the player enters the range
        if (other.gameObject.name == "Character")
        {
            hasTarget = true;
        }
    }

    // On not touching the box itself
    void OnTriggerExit2D(Collider2D collision)
    {
        // If the player enters the range
        if (collision.gameObject.name == "Character")
        {
            hasTarget = false;
        }
    }
}
