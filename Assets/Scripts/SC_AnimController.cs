using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_AnimController : MonoBehaviour
{
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OpenUpgradeMenu()
    {
        anim.SetBool("OpenMenu", true);
    }

    public void CloseUpgradeMenu()
    {
        anim.SetBool("OpenMenu", false);
    }
}
