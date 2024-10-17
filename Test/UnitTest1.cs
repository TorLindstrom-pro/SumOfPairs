using SumOfPairs;

namespace Test;

public class Tests
{
    // Given an array with exactly 5 strings "a", "b" or "c"
    // check if the array contains three and two of the same values.
    //
    //     Examples
    // ["a", "a", "a", "b", "b"] ==> true  // 3x "a" and 2x "b"
    // ["a", "b", "c", "b", "c"] ==> false // 1x "a", 2x "b" and 2x "c"
    // ["a", "a", "a", "a", "a"] ==> false // 5x "a"

    [Test]
    public void AllSameLetters_ReturnsFalse()
    {
        var result = Kata.CheckThreeAndTwo(["a", "a", "a", "a", "a"]);
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void ThreeAsAndTwoBs_ReturnsTrue()
    {
        var result = Kata.CheckThreeAndTwo(["a", "a", "a", "b", "b"]);
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void ThreeBsAndTwoAs_ReturnsTrue()
    {
        var result = Kata.CheckThreeAndTwo(["a", "b", "b", "a", "b"]);
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void ThreeCsAndTwoAs_ReturnsTrue()
    {
        var result = Kata.CheckThreeAndTwo(["a", "c", "c", "c", "a"]);
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void FourBsAndOneAs_ReturnsTrue()
    {
        var result = Kata.CheckThreeAndTwo(["a", "b", "b", "b", "b"]);
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void ThreeDifferentLetters_ReturnsFalse()
    {
        var result = Kata.CheckThreeAndTwo(["a", "b", "b", "b", "c"]);
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void IllegalLetters_ReturnsFalse()
    {
        var result = Kata.CheckThreeAndTwo(["x", "x", "x", "y", "y"]);
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void TooLongArray_ReturnsFalse()
    {
        var result = Kata.CheckThreeAndTwo(["a", "a", "a", "b", "b", "b"]);
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void TooShortArray_ReturnsFalse()
    {
        var result = Kata.CheckThreeAndTwo(["a", "a", "b", "b"]);
        Assert.That(result, Is.False);
    }
}