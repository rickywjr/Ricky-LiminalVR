using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

public Animator animator;

private int levelToLoad;

   
    public void SpawnWater()
    {
        FadeToLevel(1);
    }

    public void SpawnSky()
    {
        FadeToLevel(2);
    }

    public void SpawnCloud()
    {
        FadeToLevel(3);
    }

    public void Replay()
    {
        FadeToLevel(0);
    }



    public void FadeToLevel (int levelIndex)
   {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }

}
