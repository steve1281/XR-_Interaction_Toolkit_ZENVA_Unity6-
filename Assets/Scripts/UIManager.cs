using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Scrollbar scrollbar;

    [SerializeField]
    private TMP_Text scrollBarValueText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scrollBarValueText.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
        scrollBarValueText.text = (scrollbar ? scrollbar.value : -1.0f).ToString("F2");
    }

    public void ButtonClicked()
    {
        Debug.Log("UIManager::ButtonClicked was called.");
    }

    public void ScrollbarChanged()
    {
        float value = (scrollbar?scrollbar.value: -1.0f);
        Debug.Log("UIManager::ScrollbarChanged was called with a value of " 
            + value.ToString("F2"));
    }
}
