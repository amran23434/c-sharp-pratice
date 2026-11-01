## Chapter Three Making Decisions

## Topics

4.1 Decision Structures and the if Statement 4.2 The if-else Statemen 
4.3 Nested Decision Structures
 4.4 Logical Operators
  4.5 bool Variables and Flags 
4.6 Comparing Strings
 4.7 Preventing Data Conversion Exceptions with the TryParse Method 
 4.8 Input Validation 
 4.9 Radio Buttons and Check Boxes
  4.10 The switch Statement
  4.11 Introduction to List Boxes

## Decision Structures & the ifStatement

A control structure is a logical design that controls the order in which statements execute. A sequence structure is a set of statements that execute in the order that they appear. A decision structure execute statements only under certain circumstances , Also known as a selection structure.

## A Simple or Single Decision Structure

It provides only one alternative path of execution. It use only if clause , if the condition is true execute the body if it is not true exit the program.

## Relational Operators

A relational operator determines whether a specific relationship exists between two values .(>,<,>=,<= ,==,!=)

## The if-else Statement

An if-else statement will execute one block of statement if its Boolean expression is true or another block if its Boolean expression is false. It has two parts: an if clause and an else clause.

## Nested Decision Structures

Nested means “one inside another" , if clause inside another if clause.

## The if-else-if Statement

A decision structure that evaluates multiple conditions to make the final decision using the if-else-if statement

## Logical Operators

The logical AND operator (&&) and the logical OR operator (||) allow you to connect multiple Boolean expressions to create a compound expression The logical NOT operator (!) reverses the truth of a Boolean expression. AND operator (&&) The AND operator returns true only when all conditions are true. If at least one condition is false, the result is false. OR operator (||) The OR operator returns true when at least one condition is true. It returns false only when all conditions are false.

## Comparing Strings

You can use certain relational operators and methods to compare strings. For example, The == operator can compare two strings if (name1 == name2) { } You can compare string variables with string literals, too if (name1 != "bob") { } The String.Compare method can compare two strings if (String.Compare(name1, name2) == 0) { }

## Preventing Data Conversion Exception

The TryParse methods can prevent exceptions caused by users entering invalid data The generic syntax is: dataType.TryParse(string input, out targetVariable) The out keyword = it specifies that the targetVariable is an output variable

## Input Validation

Input validation is the process of inspecting data that has been entered into a program to make sure it is valid before it is used.

## Radio Buttons

Radio buttons allow users to select one choice from several possible choices. Radio buttons mutually exclusive selection (“you can only pick one at a time.”) Common properties are: Text: holds the text that is displayed next to the radio button Checked: a Boolean property that determines whether the control is selected or deselected

## Check boxes

Check boxes allows users to select multiple options. Common properties are: Text: holds the text that is displayed next to the radio button Checked: a Boolean property that determines whether the control is selected or deselected.

## The switch Statement

The switch statement lets the value of a variable or an expression determine which path of execution the program will take It is a multiple-alternative decision structure It can be used as an alternative to an if-else-if statement that tests the same variable or expression for several different values.

## ListBox

A ListBox is a Windows Forms control used to display a list of items and allow users to select one or more items from the list.

## Common Properties:

Text: Gets the text of the currently selected item.
Items: Contains all items in the ListBox.
Items.Count: Returns the total number of items in the ListBox.
SelectedItem: Gets or sets the currently selected item.
SelectedIndex: Gets or sets the position (index) of the selected item. Returns -1 if no item is selected.
Adding Items to a ListBox

The Items.Add method allows you to add an item to the ListBox ListBox.Items.Add(NewItem);

## Removing Items From a ListBox

using remove method or removeat method. The Items.RemoveAt method removes an item at a specific index from a ListBox. The Items.Remove method removes a specific item from a ListBox

## Clearing listBox

The Items.Clear method erases all the items in the ListBox.