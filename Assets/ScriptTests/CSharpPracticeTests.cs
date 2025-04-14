

using NUnit.Framework;
using UnityEngine;
using UnityEngine.Accessibility;

public class CsharpPracticeTests 
{
    [Test(Description = "測試數字相加")]
    [TestCase(2,2,4)]
    [TestCase(3,3,6)]
    [TestCase(-1,5,4)]
    public void Add_Two_Numbers(int a, int b, int expected)
    {
        //建立變數
        CsharpPractice csharpractice = new CsharpPractice();
        //呼叫方法,取得數值
        var result =csharpractice.Add(a,b);
        //檢查結果
        Assert.AreEqual(expected,result);
    }

    [Test(Description = "取得語言本地化文字")]
    [TestCase("Banana","香蕉")]
    [TestCase("香蕉","Banana")]
    
    public void GetLocalizationText(string key,string expectedText)
    {
        var cSharpractice = new CsharpPractice();
        var text          = cSharpractice.GetLocalizationText(key);
        Assert.AreEqual(expectedText, text);

    }
    
}


