using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Save : MonoBehaviour
{
    public GameObject namePan;

    private Saved sv = new Saved();

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Saved")) namePan.SetActive(true);
        else
        {
            sv = JsonUtility.FromJson<Saved>(PlayerPrefs.GetString("Saved"));
            Debug.Log("Добро пожаловать: " + sv.name + "\nВаш возраст: " + sv.age);

        }
    }

    public void CheckName(string name)
    {
        if (!string.IsNullOrEmpty(name) && name.Length >= 3)
        {
            sv.name = name;
            Debug.Log("Ваше имя:" + name);


        }
        else Debug.Log("Введите имя");

    }

    public void CheckAge(string age)
    {
        if (!string.IsNullOrEmpty(age) && age.Length > 0)
        {
            sv.age = int.Parse(age);
            Debug.Log("Ваш возраст" + age);

        }
        else Debug.Log("Введите нормальный возраст");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("Saved", JsonUtility.ToJson(sv));
    }
}
[Serializable]
public class Saved
{
    public string name;
    public int age;
}
