using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    private float rotationSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, Space.Self);
    }
}
