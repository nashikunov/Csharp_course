//: Playground - noun: a place where people can play

import UIKit //

var str = "Hello, playground"
let str2 = "Hello, world!" // константа
str = "hello, class!"
var number = 35
var number2: Double = 15.5
number + Int(number2)
number % 2
print("number = \(number)") // форматирование

//optionals
var optional: String? = "Optional" // в лоб

if optional != nil {
    print("optional has value")
}else{
    print("optional has not value")
}

let optional2 = optional ?? "Default value"

//func changeName(name: String?) ->
 //  String{
    //guard let unwrappedName =
       // name else { return "Something wrong"} ?????
    //return "Old name: \(unw)"
    
//        if name != nil {
//            return "Old name: \(name!), new name: Vladimir"
//        }else {
//            return "Default"
//        }
//}

var array: Array = ["1", "2", "2"]
var array2: [String] = ["4", "5", "6"]
//array2.append("2")
//for-in loop

for element in array {
    print("element = \(element)")
}

for (index, element) in array.enumerated(){
    print("element = \(element), index \(index)")
}

let secondElement = array[1]
array.map{ (element) in
    return "element = \(element)"
    
}

var array3 = ["B", "A", "C"]
array3.sort()

var dictionary = [1 : "1", 2 : "2", 3 : "3"]
//dictionary[1]

for (key, value) in dictionary {
    print("value = \(value), key = \(key)")
}
for value in dictionary.values{
    
}
for i in 1...10 {      // 1..<10
    
}

class Student {
    var name: String?
    //init(name: String) {
    //    self.name = name
    //}
    init(){
        
    }
    func badBehavior(name: String) {
        print( "\(name), bad")
    }
}

//let studentVasya = Student(name: "Vasya")
let studentVasya = Student()
studentVasya.name = "Vasya"
let unwrappedName = studentVasya.name ?? "Default name"
studentVasya.badBehavior(name: "Petya")



switch number {
case 0..<18:
    print("vam net 18")
case let age where age < 0:
    print("sorry -")
default:
    print("Ur alc")
}

switch (number, number2) {
case (0..<18, 0..<18):
    print("Sorry, u r both not 18")
case ( ,let age) where age < 0:
    print("sorry -")
default:
    break
}


