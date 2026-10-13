
namespace GithubActionsLab;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Add_Valid_Kader()
    {
        Assert.AreEqual(3, Program.Add("1", "2"));
        Assert.AreEqual(5, Program.Add("3", "2"));
        Assert.AreEqual(12, Program.Add("5", "7"));
    }

    [TestMethod]
    public void Add_Invalid_Kader()
    {
        Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
    }

    [TestMethod]
    public void Add_Null_Kader()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
    }

    [TestMethod]
    public void Subtract_Valid_Kader()
    {
        Assert.AreEqual(3, Program.Subtract("5", "2"));
        Assert.AreEqual(-2, Program.Subtract("3", "5"));
    }

    [TestMethod]
    public void Subtract_Invalid_Kader()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "2"));
    }

    [TestMethod]
    public void Subtract_Null_Kader()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "2"));
    }

    [TestMethod]
    public void Multiply_Valid_Kader()
    {
        Assert.AreEqual(12, Program.Multiply("3", "4"));
        Assert.AreEqual(0, Program.Multiply("0", "5"));
    }

    [TestMethod]
    public void Multiply_Invalid_Kader()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "3"));
    }

    [TestMethod]
    public void Multiply_Null_Kader()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "3"));
    }

    [TestMethod]
    public void Divide_Valid_Kader()
    {
        Assert.AreEqual(5, Program.Divide("10", "2"));
        Assert.AreEqual(2.5, Program.Divide("5", "2"));
    }

    [TestMethod]
    public void Divide_Invalid_Kader()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "2"));
    }

    [TestMethod]
    public void Divide_Null_Kader()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "2"));
    }

    [TestMethod]
    public void Power_Valid_Kader()
    {
        Assert.AreEqual(8, Program.Power("2", "3"));
        Assert.AreEqual(1, Program.Power("5", "0"));
        Assert.AreEqual(9, Program.Power("3", "2"));
        Assert.AreEqual(0.25, Program.Power("2", "-2"));
    }

    [TestMethod]
    public void Power_Invalid_Kader()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "2"));
    }

    [TestMethod]
    public void Power_Null_Kader()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
    }
}
