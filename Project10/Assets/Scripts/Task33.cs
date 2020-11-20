using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task33 : MonoBehaviour
{
    public int forceApplied;
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
        myCollision.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, forceApplied);
    }
}
