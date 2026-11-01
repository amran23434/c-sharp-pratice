### C# Learning Examples
This is a concise project designed for learning the basic concepts of the C# (C-Sharp) programming language. This project contains examples demonstrating the use of loops and increment/decrement operators. (*increment/decrement operators*).

---

## Code Details and Examples

 Below are the code examples included in this repository along with explanations for each concept.

### 1. While Loop
The while loop repeats code as long as the condition is  (`true`).

```csharp
// WHILE LOOP
int count = 0;
while (count < 6)
{
    MessageBox.Show("hi!");
    count++;
}
```

- **Sharrahad:** Doorsoomaha `count` waxaa lagu bilaabayaa `0`. Wareeggu wuxuu soconayaa inta `count` uu ka yar yahay `6`. Mar kasta oo uu wareeggu fashilmin, wuxuu muujinayaa fariin `"hi!"`, wuxuuna kordhinayaa `count` iyadoo la isticmaalayo `count++`.

---

### 2. Do-While LoopS
Wareegga `do-while` wuxuu dammaanad qaadayaa in koodhka gudihiisa ku jira uu samaymo **ugun yaraan hal mar**, ka hor inta al-hubin xaaladda.

```csharp
// do while loop
int counter = 0;
do
{
    counter++;
} while (counter > 5);

MessageBox.Show("Welcome");
```

- **Sharrahad:** Doorsoomaha `counter` wuxuu ka starts-garaynayaa `0`. Block-ka `do` wuxuu kordhinayaa `counter` oo uu ka dhigayaa `1`. Dhamaadka, xaaladda `counter > 5` waa been (`false`), sidaas darteed wareeggu waa uu joogsanayaa, laakiin fariinta `"Welcome"` ayaa la muujinayaa.

---

### 3. For Loop
Wareegga `for` waa habka ugu habboon uguna nadiifsan marka aad la socoto inta jeer ee aad rabto in koodhku celceliyo.

```csharp
// for loop
for (int i = 0; i < 10; i++)
{
    MessageBox.Show(i.ToString());
}
```

- **Sharrahad:** Doorsoomaha `i` waxaa lagu bilaabayaa `0`. Xaaladda `i < 10` waxay sheegaysaa in wareeggu socon doono 10 jeer (0 ilaa 9). Mar kasta oo uu gadoonmo, `i` waa la kordhiyaa (`i++`), fariin inta uu yahay qiimaha `i` muujinaysa ayaa ku soo baxaysa skreenka.

---

### 4. Pre/Post Increment & Decrement
Hawl-wadeennadan waxay kordhiyaan ama yareeyaan qiimaha doorsoomaha 1 ubucdiisa.

```csharp
// preincrement
int x = 7;
int y = 9;
y = ++x;
MessageBox.Show("after increment x: " + x);
MessageBox.Show("after increment y: " + y);

// postDecrement
int num1 = 8;
int num2 = 9;
num1 = num2--;
MessageBox.Show("after decrement number 1: " + num1);
MessageBox.Show("after decrement number 2: " + num2);
```

- **Pre-increment (`++x`):** Qiimaha `x` ayaa marka hore la kordhiyaa (wuxuu noqonayaa 8), ka dibna waxaa loo qoondeeyaa `y`.
- **Post-decrement (`num2--`):** Qiimaha hadda ee `num2` (kaas oo ah 9) ayaa lagu kaydiyaa `num1`, ka dibna `num2` ayaa 1 la yareeyaa (wuxuu noqonayaa 8).

---

### How to Run
To run these examples, you need Microsoft Visual Studio installed on your computer. Create a C# Windows Forms App or WPF App project to utilize ⁠MessageBox.Show()⁠.
1. Copy the code snippet for the example you want to test.
2. Paste it inside a button click event handler or a suitable method within your form.
3. Ensure you have ⁠using System.Windows.Forms;⁠ at the top of your file if you are using Windows Forms.
4. Run the project and trigger the code to see the results.