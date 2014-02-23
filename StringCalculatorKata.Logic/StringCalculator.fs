namespace StringCalculatorKata.Logic

open System

type StringCalculator() = 
    member x.Add stringValue = 
        if String.IsNullOrEmpty stringValue then 0
        else Int32.Parse stringValue 
