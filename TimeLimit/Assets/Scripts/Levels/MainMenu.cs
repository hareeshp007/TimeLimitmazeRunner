
using Game.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject LevelMenu;
    public GameObject MainMenuObject;
    public GameObject HowToPlay;
    private void Awake()
    {
        MainMenuObject.SetActive(true);
        HowToPlay.SetActive(false);
        LevelMenu.SetActive(false);
    }
    public void Play()
    {
        MainMenuObject.SetActive(false);
        LevelMenu.SetActive(true);
    }
    public void HowToPlayButtonPress()
    {
        MainMenuObject.SetActive(false);
        HowToPlay.SetActive(true);
    }
    public void MainMenuButtonPress()
    {
        MainMenuObject.SetActive(true);
        HowToPlay.SetActive(false);
        LevelMenu.SetActive(false);
    }
    public void LevelReset()
    {
        GameService.Instance.LevelManeger.LevelReset();
    }
    public void Exit()
    {
        Application.Quit();
    }

}
