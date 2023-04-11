using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Update is called once per frame 
    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        //We'll move the vechile forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }
}
