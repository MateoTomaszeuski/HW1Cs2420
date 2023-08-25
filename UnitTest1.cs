namespace HW1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestReverseStrings()
    {
        Assert.AreEqual(new string[] { "hi", "there" }, FileUtils.ReverseLines(new StringReader("there\nhi")));
        Assert.AreEqual(new string[] { "bye", "hi", "there" }, FileUtils.ReverseLines(new StringReader("there\nhi\nbye")));
    }

    // [Test]
    // public void TestReverseStringsInGroups()
    // {
    //     Assert.AreEqual(new string[] { "c", "b", "a" }, FileUtils.ReverseLinesInGroups(new StringReader("a\nb\nc"), 3));
    //     Assert.AreEqual(new string[] { "c", "b", "a", "f", "e", "d" }, FileUtils.ReverseLinesInGroups(new StringReader("a\nb\nc\nd\ne\nf"), 3));
    //     Assert.AreEqual(new string[] { "c", "b", "a", "f", "e", "d", "i", "h", "g", "k", "j" }, FileUtils.ReverseLinesInGroups(new StringReader("a\nb\nc\nd\ne\nf\ng\nh\ni\nj\nk"), 3));
    // }

    // [Test]
    // public void TestGetKBeforeBlank()
    // {
    //     Assert.AreEqual(new string[] { "d" }, FileUtils.KBeforeBlanks(new StringReader("a\nb\nc\nd\ne\n\n"), 2));
    //     Assert.AreEqual(new string[] { "e" }, FileUtils.KBeforeBlanks(new StringReader("a\nb\nc\nd\ne\n\n"), 1));
    //     Assert.AreEqual(new string[] { "c" }, FileUtils.KBeforeBlanks(new StringReader("a\nb\nc\nd\ne\n\n"), 3));
    //     Assert.AreEqual(new string[] { "a", "c", "" }, FileUtils.KBeforeBlanks(new StringReader("a\n\nc\n\n\n"), 1));
    //     Assert.AreEqual(new string[] { "", "c" }, FileUtils.KBeforeBlanks(new StringReader("a\n\nc\n\n\n"), 2));
    //     Assert.AreEqual(new string[] { "d", "e", "", "j" }, FileUtils.KBeforeBlanks(new StringReader("a\nb\nc\nd\ne\n\n\nh\n\nj\nk\n\n"), 2));
    // }

    // [Test]
    // public void TestUnique()
    // {
    //     Assert.AreEqual(new string[] { "a" }, FileUtils.Unique(new StringReader("a\na\n")));
    //     Assert.AreEqual(new string[] { "a", "b", "d", "c" }, FileUtils.Unique(new StringReader("a\na\nb\nd\na\nb\nc\nb\na\nc\nb\nd\na")));
    // }

    // [Test]
    // public void TestSkipFirst()
    // {
    //     Assert.AreEqual(new string[] { "a" }, FileUtils.SkipFirst(new StringReader("a\na\n")));
    //     Assert.AreEqual(new string[] { "a", "a" }, FileUtils.SkipFirst(new StringReader("a\na\na\n")));
    //     Assert.AreEqual(new string[] { "a", "a" }, FileUtils.SkipFirst(new StringReader("a\na\nb\na\n")));
    //     Assert.AreEqual(new string[] { "a", "b", "a" }, FileUtils.SkipFirst(new StringReader("b\na\na\nb\na\n")));
    //     Assert.AreEqual(new string[] { "a", "a", "b", "b", "a", "c", "b", "d", "a" }, FileUtils.SkipFirst(new StringReader("a\na\nb\nd\na\nb\nc\nb\na\nc\nb\nd\na")));
    // }

    // [Test]
    // public void TestSortUniqueByLength()
    // {
    //     Assert.AreEqual(new string[] { "a" }, FileUtils.SortUniqueByLength(new StringReader("a\na\n")));
    //     Assert.AreEqual(new string[] { "a", "aa" }, FileUtils.SortUniqueByLength(new StringReader("aa\na\n")));
    //     Assert.AreEqual(new string[] { "b", "aa" }, FileUtils.SortUniqueByLength(new StringReader("aa\nb\n")));
    //     Assert.AreEqual(new string[] { "b", "aa" }, FileUtils.SortUniqueByLength(new StringReader("aa\nb\naa\n")));
    //     Assert.AreEqual(new string[] { "b", "aa", "ab" }, FileUtils.SortUniqueByLength(new StringReader("aa\nb\nab\naa\n")));
    // }

    // [Test]
    // public void TestSortByLength()
    // {
    //     Assert.AreEqual(new string[] { "a", "a" }, FileUtils.SortByLength(new StringReader("a\na\n")));
    //     Assert.AreEqual(new string[] { "a", "aa" }, FileUtils.SortByLength(new StringReader("aa\na\n")));
    //     Assert.AreEqual(new string[] { "b", "aa" }, FileUtils.SortByLength(new StringReader("aa\nb\n")));
    //     Assert.AreEqual(new string[] { "b", "aa", "aa" }, FileUtils.SortByLength(new StringReader("aa\nb\naa\n")));
    //     Assert.AreEqual(new string[] { "b", "aa", "aa", "ab" }, FileUtils.SortByLength(new StringReader("aa\nb\nab\naa\n")));
    // }

    // [Test]
    // public void TestInterleave()
    // {
    //     Assert.AreEqual(new string[] { "a", "b" }, FileUtils.Interleave(new StringReader("a\nb\n")));
    //     Assert.AreEqual(new string[] { "a", "c", "e", "b", "d" }, FileUtils.Interleave(new StringReader("a\nb\nc\nd\ne\n")));
    // }

}

public static class FileUtils
{
    public static string[] ReverseLines(TextReader reader)
    {
        string[] reversed = new string[reader.ReadToEnd().Length];
        while (true)
        {
            string? line = reader.ReadLine();
            if (line is null)
            {
                break;
            }
            else
            {
                if (reversed[0] == "")
                {
                    reversed[0] = line;
                }
                else{
                    for (int i = 0; i <= reversed.Length; i++)
                    {
                        reversed[i+1] = reversed[i];
                        reversed[i] = line;
                    }
                }
            }
        }
        Console.WriteLine(reversed);
        return reversed;
    }
}