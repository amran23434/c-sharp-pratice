## Week Four — Loops in C#

## 5.1 The while Loop
 .Function: Causes a statement or set of statements to repeat as long as a Boolean expression is true
 .   Type: It is a pretest loop, meaning it tests the condition before executing the loop
 . If the condition is false to start with, the program will not execute it even once
 .   Infinite Loop: Occurs when the programmer forgets to write code that makes the condition false, causing the loop to run continuously without stopping until the program is closed. 
  ## 5.2 The Increment and Decrement Operators (++ and --)
   
  1. Increment (++): Increases a variable's value by 1 
   (count++ or ++count)
   2.   Decrement (--): Decreases a variable's value by 1 (count-- or --count)
   ##  Difference between Postfix and Prefix:
  1. Postfix mode (count++): Uses the variable's old value first, then changes it.   
2. Prefix mode (++count): Changes the value first, then uses it.   
 3. ## 5.3 The for Loop
 Function: A loop specially designed for situations requiring a counter variable to control the number of times a loop iterates
 ## Three Elements It Consists Of
 Initialization: Defining the initial value of the counter
 .   Test: Testing the Boolean expression (if true, the loop continues to run)
 .   Update: Increasing or decreasing the counter's value each time the loop finishes
 ## General Format:
 C#
 for (Initialization; Test; Update)
{
    // Statements
}
## 5.4The do-while Loop
Type: It is a posttest loop, meaning it performs an iteration before testing its Boolean expression
  ## General Format:
C#
do
{
    // Statements
} while (BooleanExpression);

## Major Difference: 
Unlike the while loop, the do-while loop ensures that the internal code block executes at least once even if the condition is false from the beginning. 
  ## 5.5 
  Using Files for Data StorageWhen a program needs to save data so it isn't lost when closed, it interacts with files.
## Three Basic Steps:
  Open the file: Creating a connection between the program and the file
  .   Process the file: Writing data to or reading data from the file
  .   Close the file: Disconnecting the file and the program.   
## .NET Classes:StreamWriter:
 Used for writing data using methods like WriteLine or Write. File 
 .CreateText creates a new file or erases an existing one, while File
 .AppendText adds data to an existing file without erasing what was in it
 .   StreamReader: Used for reading data using methods like ReadLine(), Read(), or ReadToEnd()
 . Also, the EndOfStream property is used to detect the end of the file during a loop (while (!reader.EndOfStream)