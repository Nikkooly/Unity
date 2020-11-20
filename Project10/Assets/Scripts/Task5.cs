using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task5 : MonoBehaviour
{
    public float sphereSpeed;
    private Rigidbody rb;
    public int forceApplied;
    public Rigidbody cubb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * sphereSpeed);
    }
    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.tag);
        switch (col.gameObject.tag)
        {
            case "GreenBox":
                Destroy(col.gameObject);
                break;
            case "BlueBox":
                col.gameObject.GetComponent<Rigidbody>().AddForce(0, forceApplied, 0);
                break;
            case "RedBox":
                Destroy(this.gameObject);
                break;
            case "YellowBox":
                    Rigidbody clone;
                    clone = Instantiate(cubb, transform.position, transform.rotation);                       
                break;
        }


    }
}
