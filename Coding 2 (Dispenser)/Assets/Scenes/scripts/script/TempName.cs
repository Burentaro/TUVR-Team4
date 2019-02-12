using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempName : MonoBehaviour
{
    public Rigidbody shiroiBoru;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            shiroiBoru.AddForce(new Vector3(-100, 0, 0));
        }
    }
}
