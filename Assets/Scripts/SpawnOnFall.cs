using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnFall : MonoBehaviour
{
    public GameObject initial;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            transform.position = initial.transform.position;
            transform.eulerAngles = initial.transform.eulerAngles;
        }
    }
}
