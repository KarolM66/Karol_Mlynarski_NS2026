using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jakiedymovement : MonoBehaviour
{
    public Rigidbody rb;
    public bool shouldFollow = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shouldFollow = !shouldFollow;
        }
        if(shouldFollow)
        {
            this.transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }


        //float horizontalInput = Input.GetAxisRaw("Horizontal");
        //rb.AddForce(new Vector3(horizontalInput * 3000,0,0) * Time.deltaTime);
    }
}
