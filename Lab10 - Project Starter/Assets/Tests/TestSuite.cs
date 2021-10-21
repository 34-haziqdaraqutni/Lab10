using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.TestTools;

public class TestSuite : MonoBehaviour
{
    public float result = 0.0f;
    [Test]
    public void TestAddition()
    {
        result = Calculator.CalculatePair(5, 2, "+");
        Assert.Equals(result, 7);
    }
    [UnityTest]
    public IEnumerator TestUnityAddition()
    {
        yield return null;
        result = Calculator.CalculatePair(5, 2, "+");
        Assert.Equals(result, 7);
    }

}
