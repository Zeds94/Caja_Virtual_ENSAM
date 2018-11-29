using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour {
    bool Male = true;

    public void SetText(string text)
    {
        if (Male)
        {
            Text txt = transform.Find("Text").GetComponent<Text>();
            txt.text = text;
        }

        if (!Male)
        {
            Text txt = transform.Find("Text").GetComponent<Text>();
            txt.text = text;
        }
    }
}
