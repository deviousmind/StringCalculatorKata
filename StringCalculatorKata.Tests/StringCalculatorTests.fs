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

    [<Test>]
    member x.Add_Returns_Value_For_String_With_Single_Value() =
        let calc = StringCalculator()
        let result = calc.Add "1"
        let expectedValue = 1
        Assert.That(result, Is.EqualTo expectedValue)