

using NUnit.Framework;

public class CSharpPracticeTests 
{
    [Test(Description = "測試數字相加")]
    [TestCase(2,2,4)]
    [TestCase(3,3,6)]
    [TestCase(-1,5,4)]
    public void Add_Two_Numbers(int a, int b, int expected)
    {
        //建立變數
        CSharpPractice cSharpractice = new CSharpPractice();
        //呼叫方法,取得數值
        var result =cSharpractice.Add(a,b);
        //檢查結果
        Assert.AreEqual(expected,result);
    }
    
}
