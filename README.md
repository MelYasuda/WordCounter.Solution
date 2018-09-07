# _Word Counter_

#### _C# MSTest exercise, September 2018_

#### By _**Mel Yasuda**_

## Description
Word Counter is a program that checks how frequently a word appears in a given string. The user should input both the word and a list of words to check. Check for full word matches only.

## Specification
1. The program takes a string as an input and input string must not be an empty string.   
  input > ""
  output > "Enter non-empty value"

  ==>The input value is an empty string because it checks if the string is empty.

2. The program splits the string into a list by spaces
  input > "google apple"
  output > {"google", "apple"}

  ==>The input value is "google apple" to test if the method splits a string with more than two words by spaces

3. The program checks if the list has more than two words
  input > {"google"}
  output > "Enter more than two words"

  ==>The input value is {"google"} to test if it returns an error if there's only one word in the list

4. The program changes upper case letter to lower case
  input > {"Google"}
  output > {"google"}

  ==>The input value is {"Google"} to test if it returns a lower-cased word

5. The program counts how many times the first word of the list appears in the list
  input > {"google", "google"}
  output > 1

  ==>The input value is {"google", "google"} to test if it returns a count of the word

## Setup/Installation Requirements
1. Clone the following repository: https://github.com/MelYasuda/word-counter.git
2. Create an exe file for WordCounter.cs open it through the terminal

## Known Bugs
TBD

## Support and contact details
* Mel, yasudamel@gmail.com

## Technologies Used
* html
* CSS
* Javascript
* C#
* MS Test

### License

Copyright (c) 2018 **_Mel Yasuda, Epicodus_**
