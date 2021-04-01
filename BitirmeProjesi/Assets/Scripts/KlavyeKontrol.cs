using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlavyeKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject yolPrefab;
    [SerializeField]
    GameObject evliyaPrefab;

    //const float hareketGucu = 10;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(evliyaPrefab, new Vector3(0, -2, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("yukarı bastın");
            Instantiate(yolPrefab, new Vector3(Random.Range(-5, +5), 6, 0), Quaternion.identity);
        }
    }
}
