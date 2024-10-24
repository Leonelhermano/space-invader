using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveaway : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(0, -180);
        transform.rotation = Quaternion.Euler(0, 0, x);
    }

    void Update()
    {
        // Move the object forward based on its local forward direction (z-axis)
        transform.Translate(Vector3.left *6 * Time.deltaTime);
    }
}
