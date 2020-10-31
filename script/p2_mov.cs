using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2_mov : MonoBehaviour
{
public float movementSpeed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update() {

        float translation = Input.GetAxis("Vertical_2") * movementSpeed;
        float rotation = Input.GetAxis("Horizontal_2") * rotationSpeed;
    

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);

        transform.Rotate(0, rotation, 0);

    }
}
