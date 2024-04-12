using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasDeger : MonoBehaviour
{
    public UnityEngine.UI.Button btn;
    public UnityEngine.UI.Text zaman, carpma, durum,durum2;
    public UnityEngine.UI.Image img;
    public Rigidbody body;
    float zamanSayaci = 0;
    int carpmaSayisi = 0;
    bool oyunDevam = true;
    bool oyunTamam = false;
    int puan = 0;
    int cizgiSayaci=0;
    
    void PuanHesapla()
    {
        if (carpmaSayisi == 0)
        {
            puan = puan+5;
        }
        if (carpmaSayisi == 1)
        {
            puan = puan + 4;
        }
        if (carpmaSayisi == 2)
        {
            puan = puan + 3;
        }
        if (carpmaSayisi == 3)
        {
            puan = puan + 2;
        }
        if(zamanSayaci<=50) 
        {
            puan = puan + 5;
        }
        if (zamanSayaci <= 60 && zamanSayaci > 50)
        {
            puan = puan + 4;
        }
        if (zamanSayaci <= 70 && zamanSayaci > 60)
        {
            puan = puan + 3;
        }
        if (zamanSayaci <= 80 && zamanSayaci > 70)
        {
            puan = puan + 2;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunDevam && !oyunTamam)
        {
            zamanSayaci += Time.deltaTime;
            zaman.text = (int)zamanSayaci + "";
        }
        else if (!oyunTamam)
        {
            durum.text = "Oyunu tamamlayamadýnýz";
            btn.gameObject.SetActive(true);
            img.gameObject.SetActive(true);
        }
        
    }
    public void OnCollisionEnter(Collision temasEdilen)
    {
        string objeIsmi = temasEdilen.gameObject.name;

        if (temasEdilen.collider.tag == "Engel")
        {
            carpmaSayisi++;
            carpma.text = carpmaSayisi.ToString();
            if (carpmaSayisi == 5)
            {
                PuanHesapla();
                durum2.text = "Kazandýðýnýz Puan: " + puan.ToString();
                oyunDevam = false;
                body.velocity = Vector3.zero;
                body.angularVelocity = Vector3.zero;
            }
        }

        if (objeIsmi.Equals("BitisCizgisi"))
        {
            cizgiSayaci++;
            
            if (cizgiSayaci==5)
            {
                oyunTamam = true;
                PuanHesapla();
                durum.text = "Oyun Tamamlandý.Tebrikler";
                durum2.text = "Kazandýðýnýz Puan: " + puan.ToString();
                btn.gameObject.SetActive(true);
                img.gameObject.SetActive(true);
                body.velocity = Vector3.zero;
                body.angularVelocity = Vector3.zero;
                
            }
            
        }
        
        
    }

}
