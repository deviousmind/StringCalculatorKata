﻿namespace StringCalculatorKata.Tests

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

    [<TestCase("1,1", 2)>]
    [<TestCase("1,2", 3)>]
    [<TestCase("2,3", 5)>]
    member x.Add_Returns_The_Sum_Of_Two_Numbers_Separated_By_A_Comma(stringValue, expectedValue) =
        let result = calc.Add stringValue
        Assert.That(result, Is.EqualTo expectedValue)

    [<TestCase("1,2,3", 6)>]
    [<TestCase("1,3,5", 9)>]
    [<TestCase("2,4,6", 12)>]
    member x.Add_Returns_The_Sum_Of_Any_Number_Of_Comma_Separated_Numbers(stringValue, expectedValue) = 
        let result = calc.Add stringValue
        Assert.That(result, Is.EqualTo expectedValue)