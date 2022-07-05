using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Login : MonoBehaviour
{
    public InputField login_text;
    public InputField password_text;

    private string logtxt = "";
    private string pastxt = "";

    private void Start()
    {
        login_text.text = "";
        password_text.text = "";
    }

    public bool Check()
    {
        logtxt = login_text.GetComponent<InputField>().text;
        pastxt = password_text.GetComponent<InputField>().text;

        if(logtxt.Length == 0)
        {
            Debug.LogError("Поле <Логин> не должно быть пустым!");
            return false;
        }
        if(pastxt.Length == 0)
        {
            Debug.LogError("Поле <Пароль> не должно быть пустым.");
            return false;
        }
        return true;
    }

    public void login_click()
    {
        if(Check())
        {
            //StartCoroutine(getUsers());
            StartCoroutine(loginUsers());
            //StartCoroutine(createjson());
        }
    }
    public void registration_click()
    {
        if(Check())
        {
            StartCoroutine(registerUsers());
        }
    }
    public void exit_click()
    {
        Application.Quit();
    }

    //IEnumerator getUsers()
    //{
    //    //WWWForm form = new WWWForm();
    //    using (UnityWebRequest www = UnityWebRequest.Get(Config.pathGetUsers))
    //    {
    //        yield return www.SendWebRequest();
    //        string json = www.downloadHandler.text;
    //        Json _json = new Json();
    //        _json = JsonUtility.FromJson<Json>(json);
    //        Debug.Log("json = " + json);
    //        Debug.Log(_json.users);
    //    }
    //}
    IEnumerator loginUsers()
    {
        string path = Config.pathLoginUsers + "?";
        path += "name=" + logtxt;
        path += "&";
        path += "password=" + pastxt;
        using (UnityWebRequest www = UnityWebRequest.Get(path))
        {
            yield return www.SendWebRequest();
            LoginUser log = JsonUtility.FromJson<LoginUser>(www.downloadHandler.text);
            if(log.code == 200)
            {
                Debug.Log(Config.code200);
                StartCoroutine(Authorization(logtxt));
            }
            else if(log.code == 404)
            {
                Debug.Log(Config.code404);
            }
        }
    }
    IEnumerator registerUsers()
    {
        string path = Config.pathRegistrationUsers + "?";
        path += "name=" + logtxt + "&" + "password=" + pastxt + "&" + "admin=0";
        using (UnityWebRequest www = UnityWebRequest.Get(path))
        {
            yield return www.SendWebRequest();
            LoginUser reg = JsonUtility.FromJson<LoginUser>(www.downloadHandler.text);
            if(reg.code == 200)
            {
                Debug.Log(Config.code200);
                StartCoroutine(Authorization(logtxt));
            }
            else if(reg.code == 405)
            {
                Debug.Log(Config.code405);
            }
            else if(reg.code == 404)
            {
                Debug.Log(Config.code404);
            }
        }
    }
    IEnumerator Authorization(string name)
    {
        Config.myName = login_text.text;
        SceneManager.LoadScene("Lobby");
        yield return null;
    }
}

[System.Serializable]
public struct LoginUser
{
    public int code;
}
