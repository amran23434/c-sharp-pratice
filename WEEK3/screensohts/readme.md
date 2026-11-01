# Chapter 3:Explaining the code for  Making Decisions 

## Concepts Used
### 1. Single Decision Structure (if Statement)
**Explanation:**
I used an `if` statement to check whether the temperature is greater than 30. If the condition is true, a message is displayed.

**Code:**
```csharp
double temp;

if (double.TryParse(texttemp.Text, out temp))
{
    if (temp > 30)
    {
        MessageBox.Show("The temperature is high");
    }
}
```

### 2. TryParse Method
**Explanation:**
I used `double.TryParse()` to validate the temperature entered by the user. It returns true if the conversion succeeds and false if it fails.
**Code:**
```csharp
double temp;

if (double.TryParse(texttemp.Text, out temp))
{
    MessageBox.Show("Valid temperature");
}
else
{
    MessageBox.Show("Please enter a numeric number");
}
```

### 3. If-Else Statement and String Comparison

**Explanation:**
I compared the text entered by the user with the word "Student". If both strings are equal, the program displays a student message; otherwise, it displays a different message.

**Code:**
```csharp
string student = textstudent.Text;

if (student == "Student")
{
    MessageBox.Show("You are a student");
}
else
{
    MessageBox.Show("You are not a student");
}
```

### 4. If-Else-If Statement and Logical Operators
**Explanation:**
I used the `if-else-if` statement to classify users according to their age. The program checks the conditions in order and displays the appropriate message.
**Code:**
```csharp
int age = int.Parse(textage.Text);

if (age <= 10)
{
    MessageBox.Show("You are a child");
}
else if (age <= 18)
{
    MessageBox.Show("You are a teenager");
}
else
{
    MessageBox.Show("You are an adult");
}
```

### 5. Nested Decision Structures
**Explanation:**
I used nested `if` statements to check the user's nationality and age. First, the program checks whether the nationality is Somali. If true, it checks whether the age is 18 or above.
**Code:**
```csharp
string nationality = textnationality.Text;

if (nationality == "Somali")
{
    if (age >= 18)
    {
        MessageBox.Show("You can vote");
    }
    else
    {
        MessageBox.Show("You are young, you cannot vote");
    }
}
else
{
    MessageBox.Show("Only Somali people can vote");
}
```

### 6. Adding Items to a ListBox
**Explanation:**
I used `Items.Add()` to display the user's nationality and age inside the ListBox named `Result`.

**Code:**
```csharp
Result.Items.Add("Nationality: " + textnationality.Text);
Result.Items.Add("Age: " + age);
```

### 7. Removing Items from a ListBox
**Explanation:**
I used `Items.Remove()` to remove a specific item from the ListBox by its value.
**Code:**
```csharp
Result.Items.Remove("Age: " + age);
```

### 8. RadioButtons

In my project, I used three RadioButtons to select the room type: Normal, Standard, and Hight.
**Explanation:**
- `Checked` checks whether a RadioButton is selected.
- If `rdonormal` is selected, the room type becomes Normal.
- If `rdostandard` is selected, the room type becomes Standard.
- If `rdohight` is selected, the room type becomes Hight.
- If no option is selected, the system displays a message and sets `approved` to false.
**Code:**
```csharp
if (rdonormal.Checked)
{
    roomType = "Normal";
}
else if (rdostandard.Checked)
{
    roomType = "Standard";
}
else if (rdohight.Checked)
{
    roomType = "Hight";
}
else
{
    MessageBox.Show("Please select room");
    approved = false;
}
```

### 9. Switch Statement
**Explanation:**
- `switch (roomType)` checks the selected room type.
- `case` represents each possible room type.
- `roomRate` stores the price of the selected room.
- `maxguest` stores the maximum number of guests allowed.
- `break` stops the switch after a matching case.
- `default` executes if no case matches.

**Code:**
```csharp
switch (roomType)
{
    case "Standard":
        roomRate = STANDARD;
        maxguest = 2;
        break;

    case "Normal":
        roomRate = NORMAL;
        maxguest = 4;
        break;

    case "Hight":
        roomRate = HIGHT;
        maxguest = 6;
        break;

    default:
        MessageBox.Show("Please select room");
        approved = false;
        break;
}
```

### 10. CheckBox
**Explanation:**
- `chkoption.Checked` checks whether the breakfast option is selected.
- If selected, the breakfast cost is calculated using the breakfast rate, number of guests, and number of nights.
- If it is not selected, the breakfast cost remains 0.

```csharp
if (chkoption.Checked)
{
    breakfast = BREAKFAST_RATE * guests * nights;
}
```