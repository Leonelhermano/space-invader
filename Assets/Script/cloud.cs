using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cloud : MonoBehaviour
{
    float x;
    public bool rigth;
    public GameObject prefabToSpawn;
    public float lifetime = 8.0f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefabToSpawn, transform.position, transform.rotation);
        rigth = true;
        x = Random.Range(0, 10);
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
  
}

