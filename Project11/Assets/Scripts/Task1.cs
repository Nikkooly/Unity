using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    public int force;
    private Rigidbody rb;
    public Material cubeMaterial;
    // Start is called before the first frame update
    void Start()
    {
        cubeMaterial = GetComponent<Renderer>().material;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        applyForce();
    }
    public void applyForce()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.rigidbody)
                {
                    hit.rigidbody.AddForce(ray.direction * force);
                    hit.collider.GetComponent<Renderer>().material.color = GetRandomColor();
                }
                
            }

        }

    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.DrawRay(collision.contacts[0].point, collision.contacts[0].normal, Color.green, 2, false);
    }

    Color GetRandomColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}
