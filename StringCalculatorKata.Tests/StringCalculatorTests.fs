namespace StringCalculatorKata.Tests

open System
open NUnit.Framework
open StringCalculatorKata.Logic

[<TestFixture>]
type StringCalculatorTests() = 

    let mutable calc = StringCalculator()

    [<SetUp>]
    member x.Init() = calc <- StringCalculator()

    [<Test>]
    member x.Add_Returns_0_For_Empty_String() =
        let result = calc.Add ""
        Assert.That(result, Is.EqualTo 0)

    [<TestCase("1", 1)>]
    [<TestCase("2", 2)>]
    [<TestCase("3", 3)>]
    member x.Add_Returns_Value_For_String_With_Single_Value(stringValue, expectedValue) =
        let result = calc.Add stringValue
        Assert.That(result, Is.EqualTo expectedValue)

    [<Test>]
    member x.Add_Returns_The_Sum_Of_Two_Numbers_Separated_By_A_Comma() =
        let result = calc.Add "1,2"
        Assert.That(result, Is.EqualTo 3)