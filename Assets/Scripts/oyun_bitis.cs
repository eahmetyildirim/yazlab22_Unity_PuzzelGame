using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class oyun_bitis : MonoBehaviour
{
    public GameObject gameObj;
    public Text scor_Yazi;
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(anaScript.level);
        int yeni_skor = 0;
        if (anaScript.level == 1)
        {
          
            if (PlayerPrefs.GetInt("level1_skor") == 0)
            {
                yeni_skor++;
                PlayerPrefs.SetInt("level1_skor", anaScript.scor);
            }
            else
            {
                if (anaScript.scor > PlayerPrefs.GetInt("level1_skor"))
                {
                    PlayerPrefs.SetInt("level1_skor", anaScript.scor);
                    yeni_skor++;
                }

            }
            Debug.Log(PlayerPrefs.GetInt("level1_skor"));
        }
        else if (anaScript.level == 2)
        {
            if (PlayerPrefs.GetInt("level2_skor") == 0)
            {
                yeni_skor++;
                PlayerPrefs.SetInt("level2_skor", anaScript.scor);
            }
            else
            {
                if (anaScript.scor > PlayerPrefs.GetInt("level2_skor"))
                {
                    PlayerPrefs.SetInt("level2_skor", anaScript.scor);
                    yeni_skor++;
                }

            }
        }
        else if (anaScript.level == 3)
        {
            if (PlayerPrefs.GetInt("level3_skor") == 0)
            {
                yeni_skor++;
                PlayerPrefs.SetInt("level3_skor", anaScript.scor);
            }
            else
            {
                if (anaScript.scor > PlayerPrefs.GetInt("level3_skor"))
                {
                    PlayerPrefs.SetInt("level3_skor", anaScript.scor);
                    yeni_skor++;
                }

            }
        }
        if (yeni_skor == 0) { 
        scor_Yazi.text = "SCOR: "+anaScript.scor;
        }
        else
        {
            scor_Yazi.text = "NEW SCOR: " + anaScript.scor;

        }
    }

    // Update is called once per frame
    void Update()
    {

  


    }

}
