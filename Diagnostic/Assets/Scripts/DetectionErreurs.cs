using UnityEngine;
using Debug = UnityEngine.Debug;

public class DetectionErreurs : MonoBehaviour
{
    public GameObject popUpFelicitation;
    private GameObject _composant;
    private string _objet;
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision" + this.tag);
        popUpFelicitation.SetActive(true);
        
        switch (this.tag)
        {
            case "CPU":
                Button.SceneID = 3;
                break;
            case "GPU":
                Button.SceneID = 3;
                break;
            case "RAM":
                Button.SceneID = 3;
                break;
        }
    }
}