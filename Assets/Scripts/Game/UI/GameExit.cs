
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameExit : MonoBehaviour
{
    public GameObject menu;
    private bool isActiveMenu = false;
  
    public void ExitInMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            isActiveMenu = !isActiveMenu;
            menu.SetActive(isActiveMenu);
        }
    }
}
