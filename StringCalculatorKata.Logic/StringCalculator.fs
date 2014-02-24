namespace StringCalculatorKata.Logic

open System

type StringCalculator() = 

    let mutable sum = 0

    member x.Add stringValue = 
        if not <| String.IsNullOrEmpty stringValue then
            let numbers = stringValue.Split(',')
            for number in numbers do
                sum <- sum + Int32.Parse(number)

        sum
