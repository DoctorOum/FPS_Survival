using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public void OnClick()
    {
        AkSoundEngine.PostEvent("Button_Press", gameObject);
    }
        
}
