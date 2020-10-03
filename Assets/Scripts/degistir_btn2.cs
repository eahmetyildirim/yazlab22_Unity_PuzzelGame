using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class degistir_btn2 : MonoBehaviour
{
    public List<Transform> butonlar = new List<Transform>();
    public List<string> btn_harfleri = new List<string>();
    public List<int> kontrol=new List<int>();
    // Start is called before the first frame update




    public void OnMouseDown()
    {

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
}
