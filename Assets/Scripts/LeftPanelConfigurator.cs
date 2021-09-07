using System;
using System.Collections;
using System.Collections.Generic;
using Model;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class LeftPanelConfigurator : MonoBehaviour
{
    [SerializeField] VerticalLayoutGroup leftPanelSections;
    [SerializeField] LeftPanelElement leftPanelElement;

    void Start()
    {
        CreateLeftPanelElements();
    }
    private void CreateLeftPanelElements()
    {
        var sections = EShopModel.Instance.GetAllSections();

        for (var index = 0; index < sections.Count; index++)
        {
            var section = sections[index];
            var element = Instantiate(leftPanelElement, leftPanelSections.transform);
            element.CreateElement(section);
        }
    }
}