using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task5 : MonoBehaviour
{
    MeshRenderer render;
    //GameObject sphere, cubb;
    public Rigidbody sphere,cubb;
    float minX, maxX, minZ, maxZ;
    float newX, newZ, newY;
    // Start is called before the first frame update
    void Start()
    {
        render = gameObject.GetComponent<MeshRenderer>();
        //cubb = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
    }

    // Update is called once per frame
    void Update()
    {
        minX = render.bounds.min.x;
        maxX = render.bounds.max.x;
        minZ = render.bounds.min.z;
        maxZ = render.bounds.max.z;

        newX = Random.Range(minX, maxX);
        newZ = Random.Range(minZ, maxZ);
        newY = gameObject.transform.position.y + 5;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody clone;
            clone = Instantiate(cubb, transform.position, transform.rotation);
            //cubb.transform.position = new Vector3(newX, newY, newZ);
            //cubb.AddComponent<Rigidbody>();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody clone;
            clone = Instantiate(sphere, transform.position, transform.rotation);
            //sphere.transform.position = new Vector3(newX, newY, newZ);
            //sphere.AddComponent<Rigidbody>();
        }
    }
}
