using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class RamDrag : MonoBehaviour
{
    public GameObject ram;
    private Animator _myAnim;

    /**
     * Caputeur l'animateur de la RAM
     */
    private void Start()
    {
        _myAnim = ram.GetComponent<Animator>();
    }

    /**
     * Coroutine qui lance la scène de fin
     */
    private IEnumerator FinDeNiveau()
    {
        yield return new WaitForSeconds(1);
        CheckPC.CheckRam = true;
        SceneManager.LoadScene("8-Tobias-fin");

    }

    /**
     * Garde la RAM sur l'axe z à 0
     */
    private void OnMouseDrag()
    {
        // mouse position to world point
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;
        transform.position = newPosition;
    }

    /**
     * Si la RAM est sur la carte mère, on lance l'animation
     */
    private void OnMouseUp()
    {
        if (DetectRam.OnMotherboard)
        {
            _myAnim.enabled = true;
        }
    }

    /**
     * Lance l'animation de la RAM
     */
    private void FinAnim()
    {   
        _myAnim.Play("ram_ok");        
        CheckPC.CheckRam = true;
        StartCoroutine(FinDeNiveau());
    }
}
