using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaPatlat : MonoBehaviour
{
    public GameObject bombaBalonu;
    OyunKontrol oyunKontrolScriptBomba;
    void Start()
    {
        oyunKontrolScriptBomba = GameObject.Find("_Scripts").GetComponent<OyunKontrol>();
    }

    private void OnMouseDown()
    {
        GameObject go = Instantiate(bombaBalonu, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.333f);
        oyunKontrolScriptBomba.bombaBalonu();
    }
}
