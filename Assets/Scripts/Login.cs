using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Login: MonoBehaviour
{
    public TMP_InputField idInputField;
    public TMP_InputField passwordInputField;

    public void OnLoginButtonclick()
    {
        string enteredID = idInputField.text;
        string enteredPassword = passwordInputField.text;

        if (enteredID == "Solitra2024" && enteredPassword == "Solitra2024")
        {
            SceneManager.LoadScene("Startup");
        }
        else
        {
            Debug.Log("Login failed. Please check your ID and password.");
        }
    }
}
