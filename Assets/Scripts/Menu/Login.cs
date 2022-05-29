using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public InputField login_text;
    public InputField password_text;

    private bool Check()
    {
        string log = login_text.GetComponent<InputField>().text;
        string pas = password_text.GetComponent<InputField>().text;

        if(log.Length == 0)
        {
            Debug.LogError("Поле <Логин> не должно быть пустым!");
            return false;
        }
        if(pas.Length == 0)
        {
            Debug.Log("Поле <Пароль> не должно быть пустым.");
            return false;
        }
        return true;
    }

    public void Click_authorization()
    {
        if(Check())
        {
            
        }
    }

    public void Click_registration()
    {
        string log = login_text.GetComponent<InputField>().text;
        string pas = password_text.GetComponent<InputField>().text;

        if(log.Length == 0)
        {
            Debug.LogError("Поле <Логин> не должно быть пустым!");
            return;
        }
        if(pas.Length == 0)
        {
            Debug.Log("Поле <Пароль> не должно быть пустым.");
            return;
        }

        if(PlayerPrefs.HasKey(log))
        {
            Debug.LogWarning("Пользователь с таким логином уже есть!");
        }
        else
        {
            PlayerPrefs.SetString(log, pas);
            PlayerPrefs.Save();
            Debug.Log("Авторизация успешна.");
        }
    }
}
