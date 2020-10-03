using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baslaButon : MonoBehaviour
{
    public void oyunaBasla()
    {
        Debug.Log("Oyuna Basla");
        anaScript.level_sahneleri_yukle();
        anaScript.level_yukle();
    }
}
