using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_AnimController : MonoBehaviour
{
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        // Gets a reference to the attached object's animator component
        anim = GetComponent<Animator>();
    }

    // Opens the upgrade store
    public void OpenUpgradeMenu()
    {
        anim.SetBool("OpenMenu", true);
    }

    // Closes the upgrade store
    public void CloseUpgradeMenu()
    {
        anim.SetBool("OpenMenu", false);
    }
}
