using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void ExitOnClick()
    {
        Debug.Log("Exiting game...");
        Application.Quit();
    }
}
