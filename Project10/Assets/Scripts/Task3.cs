using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    //public Rigidbody cube1, cube2, cube3, cube4;
    // Start is called before the first frame update
    void Start()
    {
        //cube1 = GetComponent<Rigidbody>();
        //cube2 = GetComponent<Rigidbody>();
        //cube3 = GetComponent<Rigidbody>();
        //cube4 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 45, 90) * Time.deltaTime);
    }
}
