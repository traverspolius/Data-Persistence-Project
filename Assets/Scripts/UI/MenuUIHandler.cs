using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public static MenuUIHandler menuScene;
    public TMP_InputField inputField;
    public string player_name;

    private void Awake()
    {
        if(menuScene == null)
        {
            menuScene = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartNew()
    {
        player_name = inputField.text;
        SceneManager.LoadScene(1);
    }
}
