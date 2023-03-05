using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AI : MonoBehaviour
{
    public bool hasTarget;
    public GameObject target;
    public float speed = 7f;
    public SpriteRenderer spriteRenderer;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        hasTarget = false;
        spriteRenderer.flipX = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(hasTarget)
        {
            // Go towards the target
            Vector3 newVector = (target.transform.position - this.transform.position).normalized;
            this.transform.Translate(newVector * speed * Time.deltaTime);

            // Flip X depending on direction headed
            spriteRenderer.flipX = !(newVector.x > 0);

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
                    spriteRenderer.flipX = true;
                    this.transform.Translate(((Vector3.left * speed) - this.transform.position).normalized * speed * Time.deltaTime);
                    break;
                case 3:
                    spriteRenderer.flipX = false;
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
            gm.killGoblin(this);
            SceneManager.LoadScene("fightScene");
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
