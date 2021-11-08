using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int cityHealth = 100;

    private hpScript hpScript;
    // Start is called before the first frame update
    void Start()
    {
        hpScript = GetComponent<hpScript>();
    }

    // Update is called once per frame
    void Update()
    {
        hpScript.SetHealth(cityHealth);
    }
}
