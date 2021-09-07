using Model;
using TMPro;
using UnityEngine;

class LeftPanelElement : MonoBehaviour
{
    [SerializeField] TMP_Text title;

    private Section _section = null;
    public void CreateElement(Section section)
    {
        title.text = section.GetType().Name.ToString();
        _section = section;
    }
}
