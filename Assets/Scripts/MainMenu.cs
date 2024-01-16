using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;
using Slider = UnityEngine.UI.Slider;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;

    public void OnPlayGameClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void OnSettingClicked()
    {
        SceneManager.LoadScene(2);
    }

    public void OnMainMenuClicked()
    {
        SceneManager.LoadScene(0);
    }

    public void OnSelectScene1()
    {
        SceneManager.LoadScene(3);
    }

    public void OnSelectScene2()
    {
        SceneManager.LoadScene(4);
    }

    public void OnSelectScene3()
    {
        SceneManager.LoadScene(5);
    }

    public void OnVolumnChanged()
    {
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
    }

    public GameObject groupInfo;
    public void OnGroupInfoButtonClicked()
    {
        groupInfo.SetActive(!groupInfo.activeSelf);
    }
}
