using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    public Animator menuAnim;
    public Animator swipeAnim;

    public void Swipe()
    {
        swipeAnim.SetTrigger("erase");

    }

    public void TriggerFadeOut()
    {
        menuAnim.SetTrigger("FadeOut");
        Debug.Log("bingbong");
    }
}
