using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class anaScript : MonoBehaviour
{
    public static string currentWord;
    public static int bulundu_mu = 0;
    public static List<string> selectLetter = new List<string>();
    public static int buton_sayisi;
    public static bool bitti_mi = false;
    public static List<string> level1_sahne = new List<string>();
    public static List<string> level2_sahne = new List<string>();
    public static List<string> level3_sahne = new List<string>();
    public static int level1_oyun = 2;
    public static int level2_oyun = 2;
    public static int level3_oyun = 2;
    public static int level;
    public static float gecen_sure;
    public static int ana_puan = 100000;
    public static int scor = 0;
    public static bool oyun_durumu;

    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        gecen_sure += Time.deltaTime;
      
    }
    public static int puan_hesapla()
    {
        int puan=0;
        if (gecen_sure > 0) { 
         puan = (int)(ana_puan / gecen_sure);
        }
        return puan;
    }
    public static void level_sahneleri_yukle()
    {
        for (int i = 1; i <= 6; i++)
        {
            level1_sahne.Add("level1_" + i);
            level2_sahne.Add("level2_" + i);
            level3_sahne.Add("level3_" + i);
        }
    }
    public static void level_yukle() {
        int level_i=level_sec();
        string level_adi;
        if (level1_oyun > 0)
        {
            level = 1;
            level1_oyun--;
             level_adi = level1_sahne[level_i];
            level1_sahne.RemoveAt(level_i);
            Debug.Log("Level Yukleniyor:"+level_adi);
            
        }
        else if (level2_oyun > 0)
        {
            level = 2;
            level2_oyun--;
             level_adi = level2_sahne[level_i];
            Debug.Log("Level Yukleniyor:" + level_adi);
        }
        else if (level3_oyun > 0)
        {
            level = 3;
            level3_oyun--;
             level_adi = level3_sahne[level_i];
            Debug.Log("Level Yukleniyor:" + level_adi);
        }
        else
        {
            level_adi = "";
        }
        if (level_i!=-1) {
            SceneManager.LoadScene(level_adi);
        
        }
        else
        {
            SceneManager.LoadScene("finishScreen");
           
        }
        //  Application.LoadLevel("1");

    }
    public static int level_sec(){
        int rast;
        if (level1_oyun>0)
        {
             rast = Random.Range(0, level1_sahne.Count);
        }
        else if (level2_oyun > 0)
        {
             rast = Random.Range(0, level2_sahne.Count);
        }
        else if (level3_oyun > 0)
        {
             rast = Random.Range(0, level3_sahne.Count);
        }
        else
        {
            rast = -1;
        }
        return rast;
    }

    public static int max_kelime_boyutu(List<string> kelimeler)
    {
        int enb = kelimeler[0].Length;
         for(int i = 0; i < kelimeler.Count; i++)
        {
            if(kelimeler[i].Length > enb)
            {
                enb = kelimeler[i].Length;
            }
        }
        return enb;
    } 
}
