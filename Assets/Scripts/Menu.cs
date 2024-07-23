using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public Animator menuAnim;
    public Animator abtAnim;
    public Animator swipeAnim;

    public void TriggerFadeOut()
    {
        menuAnim.SetTrigger("FadeOut");
    }

    public void Swipe()
    {
        swipeAnim.SetTrigger("Swipe");

    }



}
