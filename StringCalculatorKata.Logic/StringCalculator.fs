namespace StringCalculatorKata.Logic

open System

type StringCalculator() = 
    member x.Add stringValue = 
        if String.IsNullOrEmpty stringValue then
            0
        else
            let numbers = stringValue.Split(',')
            let mutable sum = 0
            for number in numbers do
                sum <- sum + Int32.Parse(number)
            sum
