using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLButton : MonoBehaviour
{
    public void Piano()
    {
        Application.OpenURL("https://www.play-by-ear.net/product/casio-cdp-s100-portable-digital-piano/");
    }

    public void PianoLesson()
    {
        Application.OpenURL("https://seedmusicsingapore.com/pop-piano/#");
    }

    public void tv()
    {
        Application.OpenURL("https://www.samsung.com/sg/tvs/uhd-4k-tv/au7002-65-inch-uhd-4k-smart-tv-ua65au7002kxxs/");
    }

    public void VocalLesson()
    {
        Application.OpenURL("https://seedmusicsingapore.com/pop-vocals/");
    }
}
