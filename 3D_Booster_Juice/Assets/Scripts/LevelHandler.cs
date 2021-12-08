using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHandler : MonoBehaviour
{
    public int currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextLevel()
    {
        StartCoroutine(ChangingLevel());
    }

    IEnumerator ChangingLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(currentLevel + 1);
    }
}
