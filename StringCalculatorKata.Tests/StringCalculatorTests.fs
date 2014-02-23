namespace StringCalculatorKata.Tests

open System
open NUnit.Framework
open StringCalculatorKata.Logic

[<TestFixture>]
type StringCalculatorTests() = 

    [<Test>]
    member x.Add_Returns_0_For_Empty_String() =
        let calc = StringCalculator()
        let result = calc.Add ""
        Assert.That(result, Is.EqualTo 0)

    [<TestCase("1", 1)>]
    [<TestCase("2", 2)>]
    [<TestCase("3", 3)>]
    member x.Add_Returns_Value_For_String_With_Single_Value(stringValue, expectedValue) =
        let calc = StringCalculator()
        let result = calc.Add stringValue
        Assert.That(result, Is.EqualTo expectedValue)