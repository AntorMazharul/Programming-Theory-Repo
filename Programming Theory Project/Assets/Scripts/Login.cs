using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Login : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInputField;
    [SerializeField] private GameObject warningNameInputField;
    public static string player = "";

    public void LoginToMainScene()
    {
        if (!string.IsNullOrWhiteSpace(nameInputField.text))
        {
            player = nameInputField.text;
            Debug.Log("Name: " + player);
            SceneManager.LoadScene(1);
        }
        else
        {
            warningNameInputField.SetActive(true);
        }
    }
}
