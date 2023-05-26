using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text zamanSayiText, balonSayiText,canSayiText;
    public UnityEngine.UI.Button LoadGame, HomeScreen;
    public float zamanSayaci = 60;
    int patlayanBalon = 0;
    public bool OyunBittiKontrol = false;
    public int canSayisi = 3;
    float SinirY = 5.71f;
    // Start is called before the first frame update
    void Start()
    {
        balonSayiText.text = patlayanBalon + "";
    }

    // Update is called once per frame
    void Update()
    {
        
        if (zamanSayaci > 0)
        {
        zamanSayaci -= Time.deltaTime;
        zamanSayiText.text = (int)zamanSayaci + "";
        canSayiText.text = canSayisi + "";
         
        }
        else
        {
            GameObject[] goarray = GameObject.FindGameObjectsWithTag("DuzBalon");
            for(int i =0; i < goarray.Length; i++)
            {    
                Destroy(goarray[i]);
            }
            GameObject[] gofinalBombasi = GameObject.FindGameObjectsWithTag("BombBalloon");
            for (int i = 0; i < gofinalBombasi.Length; i++)
            {
                Destroy(gofinalBombasi[i]);
            }
            GameObject[] gofinalHeart = GameObject.FindGameObjectsWithTag("HearthBalloon");
            for (int i = 0; i < gofinalHeart.Length; i++)
            {
                Destroy(gofinalHeart[i]);
            }
            OyunBittiKontrol = true;
            HomeScreen.gameObject.SetActive(true);
            LoadGame.gameObject.SetActive(true);
        }
        SiniriGecme();

    }

    public void BalonEkle()
    {
        patlayanBalon += 1;
        balonSayiText.text = patlayanBalon + "";
    }
    public void CanEkle()
    {
        canSayisi += 1;
        canSayiText.text = canSayisi + "";
    }
    public void bombaBalonu()
    {
        canSayisi -= 1;
        canSayiText.text = canSayisi + "";
        zamanSayaci -= 3;
        if (zamanSayaci > 0 && canSayisi>0)
        {
            zamanSayiText.text = (int)zamanSayaci + "";
            canSayiText.text = canSayisi + "";
            
        }
        else
        {
            zamanSayaci = 0;
            canSayisi = 0;
            GameObject[] gofinalDuz = GameObject.FindGameObjectsWithTag("DuzBalon");
            for (int i = 0; i < gofinalDuz.Length; i++)
            {
                Destroy(gofinalDuz[i]);
            }
            GameObject[] gofinalBomb = GameObject.FindGameObjectsWithTag("BombBalloon");
            for (int i = 0; i < gofinalBomb.Length; i++)
            {
                Destroy(gofinalBomb[i]);
            }
            GameObject[] gofinalHearth = GameObject.FindGameObjectsWithTag("HearthBalloon");
            for (int i = 0; i < gofinalHearth.Length; i++)
            {
                Destroy(gofinalHearth[i]);
            }
            OyunBittiKontrol = true;
            
            HomeScreen.gameObject.SetActive(true);
            LoadGame.gameObject.SetActive(true);
        }
      
    }

    public void SiniriGecme()
    {
        GameObject[] gosinirDuz = GameObject.FindGameObjectsWithTag("DuzBalon");
        for (int i = 0; i < gosinirDuz.Length; i++)
        {
            if (gosinirDuz[i].transform.position.y > SinirY)
            {
                Destroy(gosinirDuz[i]);
                canSayisi -= 1;
                if (canSayisi > 0)
                {
                    canSayiText.text = canSayisi + "";
                }
                else
                {
                    zamanSayaci = 0;
                    
                    canSayiText.text = canSayisi + "";
                    OyunBittiKontrol = true;
                    HomeScreen.gameObject.SetActive(true);
                    LoadGame.gameObject.SetActive(true);
                }
               
            }
            
        }
        GameObject[] gosinirBomb = GameObject.FindGameObjectsWithTag("BombBalloon");
        for (int i = 0; i < gosinirBomb.Length; i++)
        {
            if (gosinirBomb[i].transform.position.y > SinirY)
            {
                Destroy(gosinirBomb[i]);
            }

        }
        GameObject[] gosinirHearth = GameObject.FindGameObjectsWithTag("HearthBalloon");
        for (int i = 0; i < gosinirHearth.Length; i++)
        {
            if (gosinirHearth[i].transform.position.y > SinirY)
            {
                Destroy(gosinirHearth[i]);
            }

        }
    }
   
}
