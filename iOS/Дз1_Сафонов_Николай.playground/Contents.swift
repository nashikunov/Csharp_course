//: Playground - noun: a place where people can play

import UIKit

/// номер 1
func EvenNumber(number: Int) -> Bool{
    var Answer: Bool = false
    if number % 2 == 0 {
        Answer = true
    }
    
    return Answer
}

/// номер 2
func Division3(number: Int) -> Bool{
    var Answer: Bool = false
    if number % 3 == 0 {
        Answer = true
    }
    return Answer
}

/// номер 3
var array = [Int]()
var x: Int = 1
for _ in 0...99{
    array.append(x)
    x = x + 1
}
print(array)

/// номер 4
var b: Int = 0
var a: Int = 0
for (index, element) in array.enumerated(){
    b = index - a
    if (EvenNumber(number: element) == true || Division3(number: element) == false){
        array.remove(at: b)
        a = a + 1
    }
}
print(array)


/// номер 5
var arrayFibonachi = [Int]()
arrayFibonachi.append(1) // тк первые 2 числа в последовательности Фибоначчи по умолчанию 1 1
arrayFibonachi.append(1)

func Fibonachi(array: [Int]) -> Int{
    return array[array.count - 1] + array[array.count - 2]
    
}

for _ in 2...20{ // 100 эллементов добавить не получается. Как я понял, тк слишком большие числа выходят
    arrayFibonachi.append(Fibonachi(array: arrayFibonachi))
}
print(arrayFibonachi)


/// номер 6

var PrimeNumbers = [Int]()
var y: Int = 2
for _ in 0...540{
    PrimeNumbers.append(y)
    y = y + 1
}

var Number: Int = PrimeNumbers[0]
a = 0
b = 0
var c: Int = 0
while (Double(Number) < sqrt(550)) {
    for (index,element) in PrimeNumbers.enumerated(){
        b = index - a
        if (element % Number == 0) && (element != Number){
            PrimeNumbers.remove(at: b)
            a = a + 1
        }
        
        
        //print(PrimeNumbers)
        
    }
    c = c + 1
    a = 0
    b = 0
    Number = PrimeNumbers[c]
}
print(PrimeNumbers)
PrimeNumbers.count

// ДЗ выполнил Сафонов Николай
// 25.02.2018 










