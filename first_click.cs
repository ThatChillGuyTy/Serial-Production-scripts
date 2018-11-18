using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first_click : MonoBehaviour
{

    public string hi = "hello";

    void Start()
    {
        Physics.queriesHitTriggers = true;
    }

    void OnMouseDown()
    {
        print("CLICKED");
        gameObject.SetActive(false);
    }

    public void HideObject()
    {
        print("CLICKED");
        gameObject.SetActive(false);
    }
    public void ShowObject()
    {
        print("CLICKED");
        gameObject.SetActive(true);
    }
    public void exitGame()
    {
        Debug.Log("in ExitGame");
        Application.Quit();
    }
    public void lastAction()
    {
        StartCoroutine(Example());

    }
    public void checkWitchState()
    {
        GameObject witchGameObject = GameObject.Find("witch (1)");
        if (gameObject.activeSelf == false)
        {
            Debug.Log("ghniowgoear");
            gameObject.SetActive(true);
        }
    }
    public void checkowState()
    {
        GameObject witchGameObject = GameObject.Find("witch (1)");
        if (gameObject.activeSelf == true)
        {
            Debug.Log("ghniowgoear");
            gameObject.SetActive(true);
        }
    }

    IEnumerator Example()
    {

        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }
    
}
