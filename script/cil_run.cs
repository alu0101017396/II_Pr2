using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cil_run : MonoBehaviour
{
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            direction = new Vector3(
                (transform.position.x - other.gameObject.transform.position.x),
                (transform.position.y - other.gameObject.transform.position.y),
                (transform.position.z - other.gameObject.transform.position.z));
            gameObject.GetComponent<Rigidbody>().AddForce(direction * 10.0f);
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player") {
            gameObject.GetComponent<Rigidbody>().AddForce(-direction * 10.0f);
        }
    }
}
