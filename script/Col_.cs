using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col_ : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
    } 

    private void OnCollisionEnter(Collision other) {
        Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
        transform.GetComponent<Renderer>().material.color = newColor;
    }

    private void OnCollisionStay(Collision other) {
        if (gameObject.tag == "A" && Input.GetKeyDown(KeyCode.Space)) {
            Vector3 direction = new Vector3(
                (transform.position.x - other.gameObject.transform.position.x),
                (transform.position.y - other.gameObject.transform.position.y),
                (transform.position.z - other.gameObject.transform.position.z));
            gameObject.GetComponent<Rigidbody>().AddForce(direction * 50.0f);
        }
    }
}
