using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sahne2 : MonoBehaviour
{
    public Transform level_skor;
    public int enBkelimeU;
    public int wordLen = 0;
    public GameObject devamEt_btn;
    public Transform spelledWord;

    public List<Transform> letterler = new List<Transform>();
    public List<Transform> butonlar = new List<Transform>();

    public List<string> btn_harfleri = new List<string>();
  
    
    public List<string> kelimeler=new List<string>();
    public List<bool> kel_control=new List<bool>();
    public List<int[]> indisler = new List<int[]>();
    public int[] dizi1;
    public int[] dizi2;
    public int[] dizi3;
    public int[] dizi4;
    public int[] dizi5;
    public int[] dizi6;
    public int[] dizi7;
    public int[] dizi8;
    public int[] dizi9;
    public int[] dizi10;

    public void RastYerlestir()
    {
        List<int> kontrol = new List<int>();
        int i;
        kontrol.Clear();
        for (i = 0; i < btn_harfleri.Count; i++)
        {
            kontrol.Add(-1);
        }

        anaScript.bulundu_mu = 4;
        anaScript.currentWord = null;
        i = 0;
        while (true)
        {

            if (i == btn_harfleri.Count)
            {
                break;
            }
            int rast = Random.Range(0, btn_harfleri.Count);
            int say = 0;
            for (int j = 0; j < btn_harfleri.Count; j++)
            {
                if (kontrol[j] == rast)
                {
                    say++;
                    break;
                }

            }

            if (say > 0)
            {
                continue;
            }
            else
            {

                kontrol[i] = rast;
                i++;

            }
        }

        for (i = 0; i < btn_harfleri.Count; i++)
        {
            butonlar[i].GetComponent<TextMesh>().text = btn_harfleri[kontrol[i]];
        }

    }

    // Start is called before the first frame update
    void Start()
    {

        RastYerlestir();
        indisler.Add(dizi1);
        indisler.Add(dizi2);
        indisler.Add(dizi3);
        indisler.Add(dizi4);
        indisler.Add(dizi5);
        indisler.Add(dizi6);
        indisler.Add(dizi7);
        indisler.Add(dizi8);
        indisler.Add(dizi9);
        indisler.Add(dizi10);

        anaScript.buton_sayisi = btn_harfleri.Count;
        enBkelimeU = anaScript.max_kelime_boyutu(kelimeler);
        anaScript.gecen_sure = 0;
        anaScript.oyun_durumu=true;

        if (anaScript.level == 1)
        {

            if (PlayerPrefs.GetInt("level1_skor") != 0)
            {
                level_skor.GetComponent<TextMesh>().text = "Level-1 Skor:" + PlayerPrefs.GetInt("level1_skor");
            }
    
      
        }
        else if (anaScript.level == 2)
        {
            if (PlayerPrefs.GetInt("level2_skor") != 0)
            {

                level_skor.GetComponent<TextMesh>().text = "Level-2 Scor:" + PlayerPrefs.GetInt("level2_skor");
            }
       
        }
        else if (anaScript.level == 3)
        {
            if (PlayerPrefs.GetInt("level3_skor") != 0)
            {

                level_skor.GetComponent<TextMesh>().text = "Level-3 Scor:" + PlayerPrefs.GetInt("level3_skor");
            }
        
        }


    }

    // Update is called once per frame
    void Update()
    {
        spelledWord.GetComponent<TextMesh>().text = anaScript.currentWord;
 
        if (clickedControl.kontrol_et == true) { 
        kelime_var_mi();
            clickedControl.ilk_tiklama = false;
            oyun_bitti_mi();
            clickedControl.kontrol_et = false;
        }
      

    }
    public void oyun_bitti_mi()
    {
        int say = 0;
        for(int i = 0; i < kel_control.Count; i++)
        {
            if (kel_control[i] == false)
            {
                say++;
            }
        }
        if (say == 0)
        {
            kel_control[0] = false;
            
            anaScript.scor = anaScript.puan_hesapla();
            
            anaScript.oyun_durumu = false;
            devamEt_btn.SetActive(true);

        }
    }
    public void kelime_var_mi()
    {
        if (anaScript.currentWord != null)
        {
            wordLen = anaScript.currentWord.Length;
        }
        int say = 0;
        for(int i = 0; i < kelimeler.Count; i++) { 
            if (anaScript.currentWord == kelimeler[i] && kel_control[i]==false)
            {
                int[] dizi = indisler[i];
                for(int j = 0; j < dizi.Length;j++) {
                    string select_kelime = "";
                    for (int z = 0; z < anaScript.selectLetter.Count; z++)
                    {
                        select_kelime += anaScript.selectLetter[z];
                    }
                    Debug.Log(kelimeler[i]+" - "+select_kelime);

                    letterler[dizi[j]].GetComponent<TextMesh>().text = anaScript.selectLetter[j];
                }
                anaScript.currentWord = "";
                wordLen = 0;
                anaScript.selectLetter.Clear();
                kel_control[i] = true;
                say++;
            }
        }
        if (say==0) { 
        anaScript.currentWord = "";
        wordLen = 0;
        anaScript.selectLetter.Clear();
        }
    }
}
