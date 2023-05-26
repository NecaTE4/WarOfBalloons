using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanBalonuPatla : MonoBehaviour
{
    public GameObject canBoom;
    OyunKontrol oyunKontrolScripts;
    void Start()
    {
        oyunKontrolScripts = GameObject.Find("_Scripts").GetComponent<OyunKontrol>();
    }

    private void OnMouseDown()
    {
        GameObject go = Instantiate(canBoom, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.217f);
        oyunKontrolScripts.CanEkle();
    }
}
