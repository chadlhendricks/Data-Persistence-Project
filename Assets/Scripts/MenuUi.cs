using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUi : MonoBehaviour
{
    public Button startButton;
    public TMP_InputField inputField;
    public TextMeshProUGUI textDisplayed;


    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        textDisplayed.text = PlayerPrefs.GetString("user_name");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void StoreName()
    {
        textDisplayed.text = inputField.text;
        PlayerPrefs.SetString("name", textDisplayed.text);
        PlayerPrefs.Save();
    }
}
