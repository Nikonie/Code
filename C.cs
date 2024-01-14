using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dan1;
    public GameObject dan2;


    public void Activate1()
    {
        dan1.SetActive(true);
    }
    public void Activate2()
    {
        dan2.SetActive(true);
    }
    /// /
    /// </summary>
    public void Hide1()
    {
        dan1.SetActive(false);
    }
    public void Hide2()
    {
        dan2.SetActive(false);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
