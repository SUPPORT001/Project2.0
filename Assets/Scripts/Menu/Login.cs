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

    public List<Users> users = new List<Users>();

    [SerializeField] private string path_getUsers;

    public bool Check()
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
            Debug.LogError("Поле <Пароль> не должно быть пустым.");
            return false;
        }
        return true;
    }

    public void getUsers_click()
    {
        StartCoroutine(getUsers());
    }

    IEnumerator getUsers()
    {
        //WWWForm form = new WWWForm();
        using (UnityWebRequest www = UnityWebRequest.Get(path_getUsers))
        {
            yield return www.SendWebRequest();
            if (UnityWebRequest.Result.ConnectionError == UnityWebRequest.Result.ProtocolError)
            {
                
            }
            else
            {
                Users unit = JsonUtility.FromJson<Users>(www.downloadHandler.text);
                Debug.Log(JsonUtility.FromJson<Users>(www.downloadHandler.text));
                //Debug.Log("id: " unit.id);
            }
            
        }
        //yield return form;
    }

    

    public void Click_registration()
    {

    }

    

    /*
    IEnumerator Img()
    {
        //Texture2D texture = profileImage.canvasRenderer.GetMaterial().mainTexture as Texture2D;
        var request = UnityWebRequestTexture.GetTexture("https://pp.userapi.com/c841023/v841023649/761a/0TLleJA7dSk.jpg");
        yield return request.SendWebRequest();
        Texture2D response = (DownloadHandlerTexture.GetContent(request));
        print(request);
        GameObject go = new GameObject("image");
        Sprite sp = Sprite.Create(response, new Rect(0, 0, response.width, response.height), Vector2.zero);
        go.AddComponent<Image>().sprite = sp;
        go.Equals(enabled);
        request.Dispose();
    }
    */
}

public class Users
{
    public int id;
    public string name;
    public string admin;
}
