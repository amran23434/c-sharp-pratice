File Operations Project

This repository contains C# Windows Forms source code for managing file operations and integrating with a ListBox control.

Overview of Functions & Logic

1. File Initialization (btnCreate_Click)

File.CreateText(docPath): Creates or overwrites MyData.txt.

using statement: Automatically disposes and closes the StreamWriter resource without explicitly calling .Close().

2. Loading Data (btnRead_Click)

File.Exists(docPath): Verifies whether the target text file exists before attempting to read.

File.ReadAllLines(docPath): Reads all lines into a string array.

for loop: Iterates through the array indices to insert each item into listBox1.

3. Deleting Selected Item (btnRemoveItem_Click)

listBox1.SelectedIndex: Checks if an active selection exists in the ListBox (!= -1).

listBox1.Items.RemoveAt(...): Removes the specific line from memory.

File Overwrite: Iterates over remaining ListBox elements with foreach and writes them back into MyData.txt.

4. File Removal (btnRemoveFile_Click)

File.Delete(docPath): Permanently deletes MyData.txt from disk and clears the ListBox UI.