using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainUi : MonoBehaviour
{
    public TextMeshProUGUI displayName; 

    // Start is called before the first frame update
    void Start()
    {
        displayName.text = PlayerPrefs.GetString("name");
    }


}
