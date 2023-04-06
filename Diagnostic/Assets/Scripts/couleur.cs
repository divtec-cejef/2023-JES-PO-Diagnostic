using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class couleur : MonoBehaviour
{
    static Color[] colours = new Color[] { Color.white, Color.red, Color.green, Color.blue };
    static private int currentColor;
    // Use this for initialization
    
    public void Change(Image objet)
    {
        Debug.Log("Change couleur");
        if (!(currentColor == colours.Length - 1))
        {
            currentColor = (currentColor + 1) % colours.Length;
            objet.color = colours[currentColor];
        } else
        {
            objet.gameObject.SetActive(false);
        }
    }

    static void ChangerScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}