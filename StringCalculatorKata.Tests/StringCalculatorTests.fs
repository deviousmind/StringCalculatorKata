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