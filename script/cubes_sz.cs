using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubes_sz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other) {   
        if (other.gameObject.tag == "A" || other.gameObject.tag == "Sphere") {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        } else if (other.gameObject.tag == "Player") {
            Debug.Log("AAA");
            transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
        }
    }
}
