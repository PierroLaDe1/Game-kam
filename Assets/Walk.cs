using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    private RaycastHit Hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit, 2))
        {
            transform.Rotate(Vector3.up * Random.Range(50, 200));
        }
    }
}
