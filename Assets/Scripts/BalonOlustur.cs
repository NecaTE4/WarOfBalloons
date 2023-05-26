using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlustur : MonoBehaviour
{
    public GameObject balon;
    public GameObject canBalonu;
    public GameObject BombaBalonu;
    float balonOlusturmaSuresi = 1f;
    float zamanSayaci = 0f;
    float canBalonuOlusturmaSuresi = 11.36f;
    float canZamanSayaci = 2f;
    float bombaBalonuOlusturmaSuresi =8.63f;
    float bombaBalonuSayaci = 1f;
  //  int surehesaplama6 = 6;
  //  int surehesaplama9 = 9;
  //  int surehesaplama12 = 12;

    OyunKontrol okscript;
    // Start is called before the first frame update
    void Start()
    {
        okscript = this.gameObject.GetComponent<OyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        canZamanSayaci -= Time.deltaTime;
        bombaBalonuSayaci -= Time.deltaTime;
        if (zamanSayaci < 0 && okscript.zamanSayaci>0)
        {
            int HizKatsayi = ((int)okscript.zamanSayaci / 10) - 6 ;
            HizKatsayi *= -1;
            GameObject gameOb = Instantiate(balon, new Vector3((Random.Range(-2.5f, 2.5f)), -6.31f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            gameOb.GetComponent<Rigidbody2D> ().AddForce(new Vector3(0, Random.Range(80f * HizKatsayi, 150f * HizKatsayi), 0));
            zamanSayaci = balonOlusturmaSuresi;
            

        }
        if (canZamanSayaci < 0 && okscript.zamanSayaci > 0)
        {
            int HizKatsayi = ((int)okscript.zamanSayaci / 10) - 6;
            HizKatsayi *= -1;
            GameObject gameObCan = Instantiate(canBalonu, new Vector3((Random.Range(-2.5f, 2.5f)), -6.31f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            gameObCan.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(80f * HizKatsayi, 150f * HizKatsayi), 0));
            canZamanSayaci = canBalonuOlusturmaSuresi;
        }
        if (bombaBalonuSayaci < 0 && okscript.zamanSayaci > 0)
        {
            int HizKatsayi = ((int)okscript.zamanSayaci / 10) - 6;
            HizKatsayi *= -1;
            GameObject gameObBomba = Instantiate(BombaBalonu, new Vector3((Random.Range(-2.5f, 2.5f)), -6.31f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            gameObBomba.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(80f * HizKatsayi, 150f * HizKatsayi), 0));
            bombaBalonuSayaci = bombaBalonuOlusturmaSuresi;
        }
    }
}
