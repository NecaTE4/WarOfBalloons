using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonBatlat : MonoBehaviour
{
    public GameObject boom;
    OyunKontrol oyunKontrolScript;
    void Start()
    {
        oyunKontrolScript = GameObject.Find("_Scripts").GetComponent<OyunKontrol>();    
    }

    private void OnMouseDown()
    {
        GameObject go = Instantiate(boom, transform.position, transform.rotation) as GameObject ;
        Destroy(this.gameObject);
        Destroy(go, 0.217f);
        oyunKontrolScript.BalonEkle();
    }
}

