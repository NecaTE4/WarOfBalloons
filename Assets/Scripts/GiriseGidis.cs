using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GiriseGidis : MonoBehaviour
{
    public void Girisekrani()
    {
        SceneManager.LoadScene("GirisScene");
    }
    public void OyunEkrani()
    {
        SceneManager.LoadScene("Oyun");
    }
   /* public void AyarlaraGit()
    {
        SceneManager.LoadScene("Settings");
    }*/
    public void GoToHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
