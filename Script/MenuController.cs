using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OyunaBasla()
    {
        SceneManager.LoadScene("Secenek");
    }
    public void Yol1()
    {
        SceneManager.LoadScene("Example");
    }
    public void Yol2()
    {
        SceneManager.LoadScene("Yol2");
    }
    public void Cýkýs()
    {
        Application.Quit();
    }
    public void AnaMenuDon()
    {
        SceneManager.LoadScene("AnaMenu");
    }
    public void Hazirlayan()
    {
        SceneManager.LoadScene("Hazirlayan");
    }
    public void Ayarlar()
    {
        SceneManager.LoadScene("Ayarlar");
    }
}
