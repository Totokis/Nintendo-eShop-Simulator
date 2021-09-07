using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Model;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestScript
{
    [Test]
    public void CheckFirstReturnType()
    {
        var result = EShopModel.Instance.GetAllSections();
        
        Assert.AreEqual(typeof(Search),result.First().GetType());
    }
}
