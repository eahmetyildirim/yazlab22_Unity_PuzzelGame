using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickedControl : MonoBehaviour
{
     bool  tiklandi_mi = false;

    public static bool ilk_tiklama = false;
    public static bool kontrol_et = false;
    TextMesh yazi;

    // Start is called before the first frame update
    void Start()
    {

     
    }

    // Update is called once per frame
    void Update()
    {
   
            
            if (ilk_tiklama == false) { 
          
            yazi = GetComponent<TextMesh>();
            anaScript.currentWord = "";
            yazi.color = Color.black;
            tiklandi_mi = false;
     
            }
            
           
        
    }
    public void harf_sec()
    {
        anaScript.currentWord += GetComponent<TextMesh>().text;
        anaScript.selectLetter.Add(GetComponent<TextMesh>().text);
        yazi = GetComponent<TextMesh>();
        yazi.color = Color.yellow;

        Debug.Log(anaScript.currentWord);
        tiklandi_mi = true;
      
    }
    public void OnMouseDown()
    {
      
        if (ilk_tiklama==false && tiklandi_mi == false) {
            ilk_tiklama = true;
            harf_sec();
        }
        
    }

    public void OnMouseEnter()
    {
        if (ilk_tiklama == true && tiklandi_mi == false)
        {
            harf_sec();
        }
    }
    public void OnMouseUp()
    {
       
        kontrol_et = true;

    }

}
