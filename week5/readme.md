# C# Windows Forms Code Reference

This repository contains code snippets and detailed explanations for common C# Windows Forms operations, including File I/O (Save/Open text files) and Random Number Generation.

---

## 1. Saving Notes to a File (Save Notes)

This code snippet allows you to save text from a `TextBox` control into a text file chosen by the user via a `SaveFileDialog`.

### Code
```csharp
if (saveFileDialog1.ShowDialog() == DialogResult.OK)
{
    using (StreamWriter outputFile = File.CreateText(saveFileDialog1.FileName))
    {
        outputFile.WriteLine(txtNotes.Text);
    }
    
    MessageBox.Show("Notes saved successfully!");
}
```

### Explanation
* **`saveFileDialog1.ShowDialog()`**: Opens the file save dialog box so the user can choose the location and filename.
* **`StreamWriter outputFile = File.CreateText(...)`**: Creates or opens a new text file at the specified path for writing.
* **`outputFile.WriteLine(txtNotes.Text);`**: Writes the text content from `txtNotes` into the file.
* **`MessageBox.Show(...)`**: Displays a pop-up dialog confirming the operation was successful.

---

## 2. Reading Notes from a File (Open Notes)

This code snippet allows you to read text from an existing file selected via `OpenFileDialog` and load it into a `TextBox`.

### Code
```csharp
if (openFileDialog1.ShowDialog() == DialogResult.OK)
{
    using (StreamReader inputFile = File.OpenText(openFileDialog1.FileName))
    {
        txtNotes.Text = inputFile.ReadToEnd();
    }
    
    MessageBox.Show("File opened successfully!");
}
```

### Explanation
* **`openFileDialog1.ShowDialog()`**: Displays the file selection dialog box.
* **`StreamReader inputFile = File.OpenText(...)`**: Opens the selected file for read access.
* **`txtNotes.Text = inputFile.ReadToEnd();`**: Reads the entire text stream to the end and assigns it to `txtNotes.Text`.
* **`MessageBox.Show(...)`**: Displays a confirmation message indicating the file was opened successfully.

---

## 3. Random Number Generator

This event handler generates a random integer within a specified range when a button (`btnRandom`) is clicked and displays it in a `Label`.

### Code
```csharp
private void btnRandom_Click(object sender, EventArgs e)
{
    Random random = new Random();
    
    int number = random.Next(1, 11);
    
    lblRandomNumber.Text = number.ToString();
}
```

### Explanation
* **`Random random = new Random();`**: Instantiates a new pseudo-random number generator object.
* **`int number = random.Next(1, 11);`**: Generates a random integer between **1 and 10** (the upper bound `11` is exclusive).
* **`lblRandomNumber.Text = number.ToString();`**: Converts the generated integer to a string and sets it to `lblRandomNumber` for UI display.