# **Algorithm for converting Arabic numerals or "decimals" to Roman numerals**</span></span>

This algorithm has the function of converting the Arabic numerals, which are the numbers that we use in everyday life —except zero (0)—, to Roman numerals, which use as nomenclature the use of capital letters as symbols (from four thousand (4,000) are written with a dash above each letter). Keep in mind that this algorithm only allows you to convert Arabic numerals up to nine hundred and ninety-nine thousand, nine hundred and ninety-nine (999,999).

---
## *Requirements*
---
<details>
  <summary>Functional Requirements</summary>

* The algorithm must allow the entry of Arabic numerals (1, 2, 3, ...).
* The algorithm must be able to convert the given Arabic number to a Roman number.
* The algorithm must not allow the entry of numbers less than or equal to zero (0).
* The algorithm must not allow the input of rational numbers.
* The algorithm must not allow the input of any character type (a, b, c, @, #, ...).
* The algorithm should not allow the entry of Arabic numerals greater than one million (1,000,000), counting this one.
* The algorithm must not allow empty fields to be accepted.
</details>

<details>
  <summary>Non-functional Requirements</summary>

* The algorithm is going to be executed in a console application.
* The response time between the user input and the algorithm must be less than 5 seconds.
* The language of the algorithm will be English.
* The language of the console application will be English.
</details>

---
## *Criteria of acceptance*
---
* The user can enter Arabic numbers between one and nine hundred and ninety-nine thousand, nine hundred and ninety-nine (1-999,999), and the algorithm converts said number into Roman notation.
* The user receives an error message if they enter rational numbers.
* The user receives an error message if they enter numbers less than or equal to zero (0).
* The user receives an error message if they enter Arabic numerals greater than one million (1,000,000).
* The user receives an error message if they enter any character type (a, b, c, @, #, ...).
* The user receives an error message if they don’t enter any input.

---
## *Test cases*
---
<details>
  <summary> <span style='font-weight:bold;'><span style='color:#FFFFFF;'>End-To-End</span></span> </summary>

1. **User Functions**
    1. *If the user inserts Arabic numerals*
        - Start the program.
        - Insert a valid Arabic number.
        - See the number inserted in its roman form.
        - Exit the program.
2. **Conditions**
    1. *If the user enters a negative number*
        - Start the program.
        - Insert a negative number.
        - Receive error message.
        - Retry the conversion.
    2. *If the user enters the digit zero (0)*
        - Start the program.
        - Enter the digit zero (0).
        - Receive error message.
        - Retry the conversion.
    3. *If the user enters a rational number*
        - Start the program.
        - Insert a rational number.
        - Receive error message.
        - Retry the conversion.
    4. *If the user enters an Arabic number greater than one million (1,000,000)*
        - Start the program.
        - Insert an Arabic number greater than one million (1,000,000)
        - Receive error message.
        - Retry the conversion.
    5. *If the user enters a character of any type*
        - Start the program.
        - Insert a character.
        - Receive error message.
        - Retry the conversion.
    6. *If the user doesn’t enter an input*
        - Start the program.
        - Doesn’t enter an input.
        - Receive error message.
        - Retry the conversion.
3. **Test Cases**
    1. *User Functions 1.0*
        - The client starts the program.
        - Insert the number 5.
        - They receive the message “The Arabic numeral 5 in Roman form is V”.
        - The program closes.
    2. *Conditions 1.0*
        - The client starts the program.
        - Choose the option “Insert Arabic number”.
        - Insert the number -9.
        - They receive the message “It isn't possible to convert this digit/character to a Roman numeral.”.
        - The client retries the conversion.
    3. *Conditions 2.0*
        - The client starts the program.
        - Choose the option “Insert Arabic number”.
        - Insert the number 0.
        - They receive the message “It isn't possible to convert this digit/character to a Roman numeral.”.
        - The client retries the conversion.
    4. *Conditions 3.0*
        - The client starts the program.
        - Choose the option “Insert Arabic number”.
        - Insert the number 2.42.
        - They receive the message “It isn't possible to convert this digit/character to a Roman numeral.”.
        - The client retries the conversion.
    5. *Conditions 4.0*
        - The client starts the program.
        - Choose the option “Insert Arabic number”.
        - Insert the number 1111111111.
        - They receive the message ”This number exceeds the limit imposed in the algorithm.”.
        - The client retries the conversion.
    6. *Conditions 5.0*
        - The client starts the program.
        - Choose the option “Insert Arabic number”.
        - Insert the char @.
        - They receive the message ”It isn't possible to convert this digit/character to a Roman numeral.”.
        - The client retries the conversion.
    7. *Conditions 6.0*
        - The client starts the program.
        - Doesn’t enter an input.
        - They receive the message ”You must enter a value.”.
        - The client retries the conversion.
</details>

<details>
  <summary> <span style='font-weight:bold;'><span style='color:#FFFFFF;'>Unit</span></span> </summary>

1. **White box**
    1. *Data validation method.*
        - This method should validate each string input that is written. It will check that the input is not null, and when it is not, it will make sure that the entire string is made up of numbers. If that case is true, it will check that the numbers are above zero (0), and that they are not rational numbers. After this, it will validate that the numbers do not exceed nine hundred and ninety-nine thousand, nine hundred and ninety-nine (999,999).
    2. *Method to save each digit inside the array.*
        - This method should store each element of the string within a position in the array. Depending on the length of the string, each element of the string will be stored in the array, starting from position zero (0). The limit of the array must be 6 digits.
    3. *Method to assign each digit the corresponding symbol.*
        - This method should display in the console the Arabic number converted to Roman. For this, it will check the length of the string, and depending on what it is, it will convert the string to an int and divide it by 10, 100, 1000, 10000, or 100000. The resulting quotient will be the position of that number in roman form within the array where each annotation is. It will save the symbol that is in that position in a new variable, which will be shown in the console at the end of the algorithm, and it will divide the next number in the array, if there are more, following the same process as before.

2. **Low level**
    1. *Data validation method.*
        - Input: 54
        - Output expected: Valid.
    2. *Method to save each digit inside the array.*
        - Input: 758
        - Output expected: array[7,5,8]
    3. *Method to assign each digit the corresponding symbol.*
        - Input: 222
        - Output expected: CCXXII
</details>
