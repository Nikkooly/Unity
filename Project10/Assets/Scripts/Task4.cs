using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.tag == "Box")
        {
            Destroy(myCollision.gameObject, 1.0f);
        }
    }
}
