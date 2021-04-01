using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvliyaKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            position.x -= 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            position.x += 1;
        }
        transform.position = position;

    }
}
