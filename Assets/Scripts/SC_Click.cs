using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_Click : MonoBehaviour
{
    private int clicks = 0;
    public Text clickAmount;

    // Multiclick Variables
    private bool multiClick = false;
    private int multiBonus = 0;
    public Text clickBonusCounter;

    // Auto-Click Variables
    private bool autoClick = false;
    private int autoBonus = 1;
    public Text autoBonusCounter;

    public GameObject upgradeMenu;

    private void Update()
    {
        // Updates the text to display the current amount of clicks.
        clickAmount.text = clicks.ToString();
    }

    // called When the player clicks on the main button.
    public void Click()
    {
        clicks++;

        // If multiclick is active, add the multiclick bonus on top.
        if (multiClick)
        {
            clicks = clicks + multiBonus;
        }
    }

    // Called when the player upgrades their multiclick ability.
    // Upgrades the amount of clicks the player receives per click.
    public void MultiClick()
    {
        if (clicks >= 50)
        {
            clicks -= 50;
            multiClick = true;
            multiBonus++;
            clickBonusCounter.text = ("Bonus Clicks per click = " + multiBonus.ToString());
        }
    }

    // // Called when the player upgrades their auto-clicker ability.
    public void AutoClick()
    {
        if (clicks >= 200)
        {
            clicks -= 200;
            if (autoClick == false)
            {
                autoClick = true;
                StartCoroutine(AutoGather());
                autoBonusCounter.text = ("Bonus Clicks /1s = " + autoBonus.ToString());
            }
                
            else if (autoClick == true)
            {
                autoBonus++;
                autoBonusCounter.text = ("Bonus Clicks /1s = " + autoBonus.ToString());
            }   
        }
    }

    // While autoclick is active, adds a bonus click each second equal to a variable.
    IEnumerator AutoGather()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            clicks = clicks + autoBonus;
        }   
    }
}
