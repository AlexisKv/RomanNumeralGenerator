using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeral.Services;

namespace RomanNumeral.Tests;

[TestClass]
public class GeneratorServicesTest
{
    private GeneratorServices _generatorServices;
    
    [TestInitialize]
    public void Setup()
    {
        _generatorServices = new GeneratorServices();
    }

    [TestMethod]
    public void GeneratorServices_ShouldReturnCorrectRomanFrom1()
    {
        _generatorServices.Generate(1).Should().Be("I");
    }
    
    [TestMethod]
    public void GeneratorServices_2_II()
    {
        Assert.AreEqual("II", _generatorServices.Generate(2));
    }

    [TestMethod]
    public void GeneratorServices_3_III()
    {
        Assert.AreEqual("III", _generatorServices.Generate(3));
    }

    [TestMethod]
    public void GeneratorServices_4_IV()
    {
        Assert.AreEqual("IV", _generatorServices.Generate(4));
    }

    [TestMethod]
    public void GeneratorServices_5_V()
    {
        Assert.AreEqual("V", _generatorServices.Generate(5));
    }

    [TestMethod]
    public void GeneratorServices_9_IX()
    {
        Assert.AreEqual("IX", _generatorServices.Generate(9));
    }

    [TestMethod]
    public void GeneratorServices_10_X()
    {
        Assert.AreEqual("X", _generatorServices.Generate(10));
    }

    [TestMethod]
    public void GeneratorServices_49_XLIX()
    {
        Assert.AreEqual("XLIX", _generatorServices.Generate(49));
    }

    [TestMethod]
    public void GeneratorServices_50_L()
    {
        Assert.AreEqual("L", _generatorServices.Generate(50));
    }

    [TestMethod]
    public void GeneratorServices_100_C()
    {
        Assert.AreEqual("C", _generatorServices.Generate(100));
    }

    [TestMethod]
    public void GeneratorServices_400_CD()
    {
        Assert.AreEqual("CD", _generatorServices.Generate(400));
    }

    [TestMethod]
    public void GeneratorServices_500_D()
    {
        Assert.AreEqual("D", _generatorServices.Generate(500));
    }

    [TestMethod]
    public void GeneratorServices_900_CM()
    {
        Assert.AreEqual("CM", _generatorServices.Generate(900));
    }

    [TestMethod]
    public void GeneratorServices_1000_M()
    {
        Assert.AreEqual("M", _generatorServices.Generate(1000));
    }

    [TestMethod]
    public void GeneratorServices_11984_MMMMMMMMMMMCMLXXXIV()
    {
        Assert.AreEqual("MMMMMMMMMMMCMLXXXIV", _generatorServices.Generate(11984));
    }
    
    // public void 
}