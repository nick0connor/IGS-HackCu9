using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class move : MonoBehaviour
{
	public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
	
    void Update()
    {
		
         if ((Input.GetKeyDown(KeyCode.UpArrow))||(Input.GetKey(KeyCode.W))  )
        {  
	this.transform.Translate(Vector3.up * 10 * Time.deltaTime);
               this.transform.Translate(Vector3.down * 3 * Time.deltaTime);
        }  
         
        if ((Input.GetKey(KeyCode.DownArrow))||(Input.GetKey(KeyCode.S)) )
        {  
            this.transform.Translate(Vector3.down * 10 * Time.deltaTime);  
        }  
         
        if ((Input.GetKey(KeyCode.LeftArrow))||(Input.GetKey(KeyCode.A))   )
        {  
            this.transform.Translate(Vector3.left*10* Time.deltaTime);  
        }  
        
        if ((Input.GetKey(KeyCode.RightArrow))||(Input.GetKey(KeyCode.D))   )
        {  
            this.transform.Translate(Vector3.right *10* Time.deltaTime);  
        }  
  
    
	
	}
}
