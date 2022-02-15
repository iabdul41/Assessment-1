using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpin : MonoBehaviour
{
    public float targetSpeed = 32f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // spin the target
        transform.Rotate(Vector3.forward, Time.deltaTime * targetSpeed);
    }
}
