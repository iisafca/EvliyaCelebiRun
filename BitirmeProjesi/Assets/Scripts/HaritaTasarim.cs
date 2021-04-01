using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaritaTasarim : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            position.y -=1;
        }
        transform.position = position;
    }
}
