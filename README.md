# ![ExpressionEvaluator Icon](https://github.com/codingseb/ExpressionEvaluator/blob/master/Icon.png?raw=true "ExpressionEvaluator A Simple Math and Pseudo C# Expression Evaluator in One C# File") 
# ExpressionEvaluator

[![.NET CI](https://github.com/automotivelabs/ComputeModule/actions/workflows/dotnet.yml/badge.svg)](https://github.com/automotivelabs/ComputeModule/actions/workflows/dotnet.yml)

A Simple Math and Pseudo C# Expression Evaluator in One [C# File](./CodingSeb.ExpressionEvaluator/ExpressionEvaluator.cs).

And from version 1.2.0 can execute small C# like scripts 

It is largely based on and inspired by the following resources [this post on stackoverflow](http://stackoverflow.com/questions/333737/evaluating-string-342-yield-int-18/333749), [NCalc](https://github.com/pitermarx/NCalc-Edge), [C# Operators](https://msdn.microsoft.com/en-us/library/6a71f45d.aspx) and [C# Statement Keywords](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/statement-keywords)


## Features
* Basic mathematical and logical expression evaluation
* System.Math methods and constants directly available (some like Max, Min, Avg are improved)
* Some useful [functions](https://github.com/codingseb/ExpressionEvaluator/wiki/Variables-and-functions#standard-functions) for example to create List and Arrays
* [Custom variables definition](https://github.com/codingseb/ExpressionEvaluator/wiki/Variables-and-functions#custom-variables)
* [On the fly variables and functions evaluation](https://github.com/codingseb/ExpressionEvaluator/wiki/Variables-and-functions#on-the-fly-variables-and-functions-evaluation) (To easily extend possibilities, Manage also on instance Property and Methods)
* [A large set of C# operators availables](https://github.com/codingseb/ExpressionEvaluator/wiki/Operators-and-Keywords#standard-operators)
* Instance and static methods and properties access like as in C#
* You can call Methods and/or Properties on your own classes (just pass a object as custom variables)
* [C# primary types](https://github.com/codingseb/ExpressionEvaluator/wiki/C%23-Types-Management#primary-types)
* Use strings as in C# (@"", $"", $@"" available)
* Lambda expressions
* Classes like File, Directory, Regex, List ... available ([You can extend the list of Namespaces](https://github.com/codingseb/ExpressionEvaluator/wiki/C%23-Types-Management#assemblies-namespaces-and-types))
* Create instance with [new(MyClassName, constructorArgs)](https://github.com/codingseb/ExpressionEvaluator/wiki/Variables-and-Functions#standard-functions) or [new MyClassName(constructorArgs)](https://github.com/codingseb/ExpressionEvaluator/wiki/Operators-and-Keywords#standard-operators)
* [Call void methods with fluid prefix convention to chain operations](https://github.com/codingseb/ExpressionEvaluator/wiki/Variables-and-Functions#go-fluid-with-a-simple-methods-prefixing-convention)
* Manage [ExpandoObject](https://github.com/codingseb/ExpressionEvaluator/wiki/ExpandoObject)
* [Create custom Operators or change the parsing process](https://github.com/codingseb/ExpressionEvaluator/wiki/Advanced-Customization-and-Hacking)

## And with [ScriptEvaluate](https://github.com/codingseb/ExpressionEvaluator/wiki/Getting-Started#small-scripts) method
* Small C# like script evaluation (Multi expressions separated by ; )
* Some conditional and loop blocks [keywords](https://github.com/codingseb/ExpressionEvaluator/wiki/Operators-and-Keywords#scripts-keywords) (if, while, for, foreach ...)
* Multi-line (multi expression) Lambda expressions. (Can be use as method [See #72 Declare methods in scripts](https://github.com/codingseb/ExpressionEvaluator/issues/72) and the [doc](https://github.com/codingseb/ExpressionEvaluator/wiki/Variables-and-Functions#simulate-function-and-methods-declaration-with-lambda-and-multiline-lambda))

## Resources
* [Getting Started](https://github.com/codingseb/ExpressionEvaluator/wiki/Getting-Started)
* [Documentation on the wiki](https://github.com/codingseb/ExpressionEvaluator/wiki)
* [Live Demos](https://dotnetfiddle.net/Packages/41132/CodingSeb_ExpressionEvaluator)
* [Try it](https://dotnetfiddle.net/up4x3W)

### License
Expression Evaluator is free and will always be.  
But if you want to say thanks for this lib with a donation or small sponsoring here you can :  
[Donate](https://www.paypal.com/donate?hosted_button_id=7K467U3H4NVJG)
Thank you anyway for using ExpressionEvaluator
