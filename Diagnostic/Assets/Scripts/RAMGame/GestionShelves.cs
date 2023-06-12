using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionShelves : MonoBehaviour
{
    public GameObject _RAMCassee;
    public GameObject _RAMRechange;
    public GameObject _ThingToActivate;
    public GameObject _ThingToDeactivate;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        _RAMCassee.SetActive(false);
        _RAMRechange.SetActive(true);
    }

    public void clicRam()
    {
        _ThingToActivate.SetActive(true);
        _ThingToDeactivate.SetActive(false);
    }

}
