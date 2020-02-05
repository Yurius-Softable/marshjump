using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{

    [SerializeField]
      InputField field;


    public void start_get()
    {
        StartCoroutine(GET());

    }

    public IEnumerator GET()
    {

        var url = "https://artpwn.pw/promo/unity_get.php?promo=";
        string data1 = field.text;
        var www = new WWW(url + data1);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Server does not respond : " + www.error);
        }
        else
        {
            if (www.text == "Good") // что нам должен ответить сервер на наши данные
            {
                Debug.Log(www.text);
            }
            else
            {
                Debug.Log("Error : " + www.text);
            }
        }
        www.Dispose();
    }
}
