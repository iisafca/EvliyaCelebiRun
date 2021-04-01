using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YolYokEdici : MonoBehaviour
{
    GeriSayimSayaci yokEdiciGeriSayim;
    // Start is called before the first frame update
    void Start()
    {
        yokEdiciGeriSayim = gameObject.AddComponent<GeriSayimSayaci>();
        yokEdiciGeriSayim.ToplamSure = 10;
        yokEdiciGeriSayim.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (yokEdiciGeriSayim.Bitti)
        {
            Destroy(gameObject);
        }
    }
}
