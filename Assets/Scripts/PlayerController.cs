using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float dartSpeed = 11f;
    public GameObject dartPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //launch a dart from the player
            Instantiate(dartPrefab, new Vector3(transform.position.x, 1, -2), dartPrefab.transform.rotation);
        }

        // spin the dart
        dartPrefab.transform.Rotate(Vector3.back, Time.deltaTime * dartSpeed);
    }
}
