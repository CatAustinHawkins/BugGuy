using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerMisc : MonoBehaviour
{

    public int Gold;
    public TextMeshProUGUI Goldtext;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Goldtext.text = Gold + "g";
    }
}
