using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverigth : MonoBehaviour
{
    float x;
    public float lifetime = 8.0f;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(0, 10);
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
    
            transform.Translate(Vector3.right * x * Time.deltaTime);
    }
}
